package com.yang.session.status;

import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class Result {
    private Integer Code;
    private String message;
    private Object data;
}
