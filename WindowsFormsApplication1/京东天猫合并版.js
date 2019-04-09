var imgArray=[];
var itemImg="";
var regex=/^http(s*):/;

function PushImage(imgPath){
    if(regex.test(imgPath)){
        imgArray.push(imgPath);
    }else{
        imgArray.push("https:"+imgPath);
    }
}
// 京东
if(window.location.href.indexOf("https://item.jd.com")>-1){
    var backgroundImageRegex=/(?<=url\(").+(?="\))/;

    // 获取大图
    document.querySelectorAll("#spec-list img").forEach(function(item,index){
        PushImage(item.src.replace("/n5/","/n12/")+"?big");
    });
    // 获取详情图1
    document.querySelectorAll("#J-detail-content img,div.ssd-module").forEach(function(item,index){
        if(item.src){
            //image
            PushImage(item.src+"?detail");
        }else{
            //A-DOM获取样式属性值：优先从DOM当前样式获取
            itemImg=item.style.backgroundImage;
            if(itemImg==null || itemImg==""){
                //然后再从样式表获取
                //非IE
                if(window.getComputedStyle){
                    itemImg=window.getComputedStyle(item)["background-image"];
                }else if(itemImg.currentStyle){
                    //IE
                    itemImg=itemImg.currentStyle["background-image"];
                }
            }
            //B-Jquery获取样式属性值：
            //itemImg=$(item).css("background-image");

            var matchResult=itemImg.match(backgroundImageRegex);
            if(matchResult!=null && matchResult.length>0){
                PushImage(matchResult[0]+"?detail");
            }
        }
    });
}else{
    // 天猫
    var bigImageReplaceRegex=/_\d+x\d+.+[jpg|png|jpeg|gif|bmp|svg|psd]$/;
    // 获取大图
    document.querySelectorAll("#J_UlThumb img").forEach(function(item,index){
        itemImg=item.src;
        itemImg=itemImg.replace(bigImageReplaceRegex,"");
        PushImage(itemImg+"?big");
    });

    // 获取详情图1
    document.querySelectorAll("#description img").forEach(function(item,index){
        PushImage(item.src+"?detail");
    });
}

console.log(imgArray.join(","));