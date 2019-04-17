var imgArray = [];
var itemImg = "";
var regex = /^http(s*):/;

function PushImage(imgPath) {
    if (regex.test(imgPath)) {
        imgArray.push(imgPath);
    } else {
        imgArray.push("https:" + imgPath);
    }
}
// ����
if (window.location.href.indexOf("//item.jd.com") > -1) {
    var backgroundImageRegex = /(?<=url\(").+(?="\))/;

    // ��ȡ��ͼ
    document.querySelectorAll("#spec-list img").forEach(function (item, index) {
        var imgSrc = item.src;
        //��ͼ����1ת800*800����/n1/s800x800_jfs/��
        var matchResult1 = imgSrc.match(/\/s\d+x\d+/);
        //��ͼ����2ת800*800����/n12/jfs/��
        var matchResult2 = imgSrc.match(/\/n\d+\//);
        if (matchResult1 != null && matchResult1.length > 0) {
            imgSrc = imgSrc.replace(matchResult1[0], "/s800x800");
        } else if (matchResult2 != null && matchResult2.length > 0) {
            imgSrc = imgSrc.replace(matchResult2[0], "/n12/");
        }
        PushImage(imgSrc + "?big");
    });
    // ��ȡ����ͼ1
    document.querySelectorAll("#J-detail-content img,div.ssd-module").forEach(function (item, index) {
        if (item.src) {
            //image
            PushImage(item.src + "?detail");
        } else {
            //A-DOM��ȡ��ʽ����ֵ�����ȴ�DOM��ǰ��ʽ��ȡ
            itemImg = item.style.backgroundImage;
            if (itemImg == null || itemImg == "") {
                //Ȼ���ٴ���ʽ���ȡ
                //��IE
                if (window.getComputedStyle) {
                    itemImg = window.getComputedStyle(item)["background-image"];
                } else if (itemImg.currentStyle) {
                    //IE
                    itemImg = itemImg.currentStyle["background-image"];
                }
            }
            //B-Jquery��ȡ��ʽ����ֵ��
            //itemImg=$(item).css("background-image");

            var matchResult = itemImg.match(backgroundImageRegex);
            if (matchResult != null && matchResult.length > 0) {
                PushImage(matchResult[0] + "?detail");
            }
        }
    });
} else {
    // ��è
    var bigImageReplaceRegex = /_\d+x\d+.+[jpg|png|jpeg|gif|bmp|svg|psd]$/;
    // ��ȡ��ͼ
    document.querySelectorAll("#J_UlThumb img").forEach(function (item, index) {
        itemImg = item.src;
        itemImg = itemImg.replace(bigImageReplaceRegex, "");
        PushImage(itemImg + "?big");
    });

    // ��ȡ����ͼ1
    document.querySelectorAll("#description img").forEach(function (item, index) {
        PushImage(item.src + "?detail");
    });
}

console.log(imgArray.join(","));