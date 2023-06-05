package com.yang.session.utils.json;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

public class ConvertJsonOrClass {
    public static String convertJavaBeanToJson(Object obj){
        if (obj == null){
            return "";
        }
        Gson gson = new Gson();
        String result = gson.toJson(obj);
        return result;
    }

    public static Object convertJsonToJavaBean(String json,Class<?> cls){
        if (json == null){
            return null;
        }
        Gson gson = new GsonBuilder().setDateFormat("yyyy-MM-dd").create();
        return gson.fromJson(json,cls);
    }

    public static String replaceDate(String str){
        return str.replace('/','-');
    }
}
