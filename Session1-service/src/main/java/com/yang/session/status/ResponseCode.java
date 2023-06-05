package com.yang.session.status;

public class ResponseCode {

    //Server response successful
    //服务器响应成功
    public static final int OK = 200;

    //Request status successful
    //请求状态成功
    public static final int RequestStatusSuccessful = 304;

    //Insufficient permissions
    //权限不足
    public static final int  IP = 403;

    //not found
    //找不到
    public static final int notFound = 404;

    //Server  error
    //服务器错误
    public static final int ServerError = 500;

    //请求失败
    public static final int RequestStatusError = 305;
}
