package com.yang.session.Service.Impl;

import com.yang.session.Mapper.WareHouseManagementMapper;
import com.yang.session.Pojo.Order;
import com.yang.session.Service.WareHouseManagementService;
import com.yang.session.status.ResponseCode;
import com.yang.session.status.Result;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class WareHouseManagementServiceImpl implements WareHouseManagementService {

    @Autowired
    private WareHouseManagementMapper wareHouseManagementMapper;

    @Override
    public Integer getHouseIdByName(Order order) {
        Integer res;
        try{
            res =  wareHouseManagementMapper.getHouseIdByName(order);
        }catch (Exception e){
            res = null;
        }
        return res;
    }
}
