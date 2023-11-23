var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/x-www-form-urlencoded");

var downLoadFunc = function (user, pageFilter, callBackFunc) {
    pageFilter.Pager.PageNumber++;
    pageFilter.DeveloperID.Value = user.DeveloperID;
    var urlencoded = new URLSearchParams();
    urlencoded.append("filter", JSON.stringify(pageFilter));
    var requestOptions = {
        method: 'POST',
        headers: myHeaders,
        body: urlencoded,
        redirect: 'follow'
    };

    fetch("https://erp.banmaerp.com/Product/Spu/SpuListData", requestOptions)
        .then(response => response.json())
        .then(result => callBackFunc(user, pageFilter, result));
}

var userArray = [
    { name: "yujia", DeveloperID: 32376, ImageArray: [] },
    { name: "xuyuanyuan", DeveloperID: 32373, ImageArray: [] },
    { name: "jingkun", DeveloperID: 32377, ImageArray: [] },
    { name: "gz", DeveloperID: 32472, ImageArray: [] },
    { name: "GZ-wanying", DeveloperID: 33445, ImageArray: [] }
];
var callBackFunc = function (user, pageFilter, result) {
    if (result.Results != null && result.Results.length > 0) {
        result.Results.forEach(img => {
            user.ImageArray.push(img.Spu.Image + "?filename=" + img.Spu.Code);
        });
        downLoadFunc(user, pageFilter, callBackFunc);
    } else {
        console.info({ name: user.name, imgs: user.ImageArray.join(",") });
    }
}
userArray.forEach(user => {
    var pageFilter = {
        "CreateTime": { "StartValue": "2023-11-22 00:00:00.000", "EndValue": "2023-11-22 23:59:59.998", "Sort": -1 },
        "Pager": { "PageNumber": 0, "PageSize": 10 },
        "DeveloperID": { "Value": 0 }
    };
    downLoadFunc(user, pageFilter, callBackFunc);
});
