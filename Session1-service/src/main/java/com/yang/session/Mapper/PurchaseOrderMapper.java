package com.yang.session.Mapper;

import com.yang.session.Pojo.Order;
import org.apache.ibatis.annotations.MapKey;
import org.apache.ibatis.annotations.Mapper;

import java.util.List;
import java.util.Map;

@Mapper
public interface PurchaseOrderMapper {
    List<String> getPartsName();
    List<String> getSuppliersName();
    List<String> getWarehousesName();
    @MapKey("Name")
    List<Map<String,Object>> getOrders();

    Integer addOrder(Order order);
    Integer addOrderItems(Order order);
}
