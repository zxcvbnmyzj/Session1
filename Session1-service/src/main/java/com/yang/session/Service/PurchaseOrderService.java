package com.yang.session.Service;

import com.yang.session.Pojo.Order;
import com.yang.session.status.Result;

import java.util.List;

public interface PurchaseOrderService {

    Result getPartsName();
    Result getSuppliersName();
    Result getWarehousesName();
    Result getOrders();

    Result addOrder(Order order);

}
