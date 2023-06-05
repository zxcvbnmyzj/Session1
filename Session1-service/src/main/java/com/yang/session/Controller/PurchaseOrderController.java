package com.yang.session.Controller;

import com.yang.session.Pojo.Order;
import com.yang.session.Service.Impl.PurchaseOrderServiceImpl;
import com.yang.session.status.Result;
import org.apache.ibatis.annotations.Param;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@Controller
public class PurchaseOrderController {

    @Autowired
    private PurchaseOrderServiceImpl purchaseOrderService;

    @GetMapping("/api/getPartName")
    @CrossOrigin
    public @ResponseBody Result getPartName(){
        return purchaseOrderService.getPartsName();
    }

    @GetMapping("/api/getSuppliersName")
    @CrossOrigin
    public @ResponseBody Result getSuppliersName(){
        return purchaseOrderService.getSuppliersName();
    }

    @GetMapping("/api/getWareHouses")
    @CrossOrigin
    public @ResponseBody Result getWareHouses(){
        return purchaseOrderService.getWarehousesName();
    }

    @GetMapping("/api/getOrders")
    @CrossOrigin
    public @ResponseBody Result getOrders(){
        return purchaseOrderService.getOrders();
    }

    @PostMapping("/api/addOrder")
    @CrossOrigin
    public @ResponseBody Result addOrder(@RequestBody Order order){
        return purchaseOrderService.addOrder(order);
    }
}
