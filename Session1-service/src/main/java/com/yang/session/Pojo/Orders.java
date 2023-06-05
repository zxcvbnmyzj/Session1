package com.yang.session.Pojo;


import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Repository;

import java.sql.Date;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Repository
public class Orders {
    private Integer osId;

    private String suppliersName;

    private String sourceWare;

    private String warehouseName;

    private Date Date;

    private String transactionType;
}
