package com.yang.session.Service;

import com.yang.session.Pojo.Order;
import com.yang.session.status.Result;

public interface WareHouseManagementService {

    Integer getHouseIdByName(Order order);
}
