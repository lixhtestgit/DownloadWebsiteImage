﻿var myHeaders = new Headers();
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
var allImageArray = [];
var userArray = [
    { name: "momo CPKF", DeveloperID: 32380, isDownloaded: false },
    { name: "xuyuanyuan", DeveloperID: 32373, isDownloaded: false },
    { name: "jingkun", DeveloperID: 32377, isDownloaded: false },
    { name: "gz", DeveloperID: 32472, isDownloaded: false },
    { name: "GZ-wanying02", DeveloperID: 33487, isDownloaded: false },
    { name: "HF-liyu01", DeveloperID: 34857, isDownloaded: false },
    { name: "HF-xionghaiwei01", DeveloperID: 34858, isDownloaded: false }
];
var callBackFunc = function (user, pageFilter, result) {
    if (result.Results != null && result.Results.length > 0) {
        result.Results.forEach(img => {
            allImageArray.push(img.Spu.Image + "?filename=" + img.Spu.Code);
        });
        downLoadFunc(user, pageFilter, callBackFunc);
    } else {
        user.isDownloaded = true;
        if (userArray.filter(m => m.isDownloaded).length == userArray.length) {
            console.info({ name: "all", imgs: allImageArray.join(",") });
        }
    }
}
userArray.forEach(user => {
    var pageFilter = {
        "CreateTime": { "StartValue": "2023-12-15 00:00:00.000", "EndValue": "2023-12-15 23:59:59.998", "Sort": -1 },
        "Pager": { "PageNumber": 0, "PageSize": 10 },
        "DeveloperID": { "Value": 0 }
    };
    downLoadFunc(user, pageFilter, callBackFunc);
});
