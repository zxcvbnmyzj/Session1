package com.yang.session.Service.Impl;

import com.yang.session.Mapper.PurchaseOrderMapper;
import com.yang.session.Pojo.Order;
import com.yang.session.Service.PurchaseOrderService;
import com.yang.session.status.ResponseCode;
import com.yang.session.status.Result;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.jnlp.DownloadService2;

@Service
public class PurchaseOrderServiceImpl implements PurchaseOrderService {

    @Autowired
    private PurchaseOrderMapper orderMapper;

    @Override
    public Result getPartsName() {
        Result res ;
        try {
            res = new Result(ResponseCode.OK,"",orderMapper.getPartsName());
        }catch (Exception e) {
            res = new Result(ResponseCode.ServerError, "Server Error", null);
        }
        return res;
    }

    @Override
    public Result getSuppliersName() {
        Result res;
        try {
            res = new Result(ResponseCode.OK,"",orderMapper.getSuppliersName());
        }catch (Exception e){
            res = new Result(ResponseCode.ServerError,"Server Error",null);
        }
        return res;
    }

    @Override
    public Result getWarehousesName() {
        Result res ;
        try {
            res = new Result(ResponseCode.OK,"",orderMapper.getWarehousesName());
        }catch (Exception e){
            res = new Result(ResponseCode.ServerError,"Server Error",null);
        }
        return res;
    }

    @Override
    public Result getOrders() {
        Result res;
        try {
            res = new Result(ResponseCode.OK,"",orderMapper.getOrders());
        }catch (Exception e){
            res = new Result(ResponseCode.ServerError,"Server Error",null);
        }
        return res;
    }

    @Override
    public Result addOrder(Order order) {
        Result res;
        try{
            Integer result = orderMapper.addOrderItems(order);
            Integer item = orderMapper.addOrder(order);
            if (result != 1 || item != 1){
                return new Result(ResponseCode.RequestStatusError,"operation failed",null);
            }
            res = new Result(ResponseCode.OK,"Operation successful",null);
        }catch (Exception e){
            res = new Result(ResponseCode.ServerError,"Server Error",null);
        }
        return res;
    }
}
