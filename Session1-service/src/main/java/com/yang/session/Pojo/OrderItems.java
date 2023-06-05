package com.yang.session.Pojo;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Repository;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Repository
public class OrderItems {
    private long OId;
    private Orders Order;
    private Parts Part;
    private String BatchNumber;
    private double Amount;
}
