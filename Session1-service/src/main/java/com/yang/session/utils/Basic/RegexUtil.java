package com.yang.session.utils.Basic;

import java.util.Random;

public class RegexUtil {
    private static String SPEICAL = "[\\\\u00A0\\\\s\\\"`~!@#$%^&*()+=|{}':;',\\\\[\\\\].<>/?~！@#￥%……&*（）——+|{}【】‘；：”“’。，、？]";

    private static String NUMBER = "^[0-9]*$";

    private static String RANDOM = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static boolean checkSpecial(String str){
        return str.matches(SPEICAL);
    }

    public static boolean checkNumber(String str){
        return str.matches(NUMBER);
    }

    public static String codeCreate(int count){
        StringBuilder stringBuilder = new StringBuilder();
        Random random = new Random();
        int num;
        for (int i = 0;i<count;i++){
            num = random.nextInt(RANDOM.length());
            stringBuilder.append(RANDOM.charAt(num));
        }
        return  stringBuilder.toString();
    }
}
