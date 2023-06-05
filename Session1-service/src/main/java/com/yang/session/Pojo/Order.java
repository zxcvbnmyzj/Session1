package com.yang.session.Pojo;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Repository;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Repository
public class Order {
    Integer Id;
    Integer OrderId;
    Integer PartId;
    String BatchNumber;
    Integer Amount;
    Integer TransactionTypeId;
    Integer SupplierId;
    Integer SourceWareHouseId;
    Integer DesWareHouseId;
    String Date;
    String PartName;
    String SuppliersName;
    String TransactionName;
    String WareHousesName;
}
