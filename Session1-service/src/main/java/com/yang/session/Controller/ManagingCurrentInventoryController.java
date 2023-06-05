package com.yang.session.Controller;

import com.yang.session.Service.Impl.ManagingCurrentInventoryServiceImpl;
import com.yang.session.status.Result;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class ManagingCurrentInventoryController {

    @Autowired
    private ManagingCurrentInventoryServiceImpl managingCurrentInventoryService;


    @GetMapping("api/getInventory")
    @CrossOrigin
    public @ResponseBody Result getInventory() {
        return managingCurrentInventoryService.getInventory();
    }
}
