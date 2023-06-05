package com.yang.session.Controller;

import com.yang.session.Pojo.Order;
import com.yang.session.Service.Impl.WareHouseManagementServiceImpl;
import com.yang.session.status.Result;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class WareHouseManagementController {

    @Autowired
    private WareHouseManagementServiceImpl wareHouseManagementService;

    @PostMapping("/api/getWareHouseName")
    @CrossOrigin
    public @ResponseBody Integer getWareHouseName(@RequestBody Order order){
        return wareHouseManagementService.getHouseIdByName(order);
    }

}
