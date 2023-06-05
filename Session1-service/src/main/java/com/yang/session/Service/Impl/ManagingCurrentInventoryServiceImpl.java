package com.yang.session.Service.Impl;

import com.yang.session.Config.redis.RedisCache;
import com.yang.session.Mapper.ManagingCurrentInventoryMapper;
import com.yang.session.Service.ManagingCurrentInventoryService;
import com.yang.session.status.ResponseCode;
import com.yang.session.status.Result;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.thymeleaf.util.StringUtils;

import java.text.SimpleDateFormat;
import java.util.List;
import java.util.Map;

@Service
public class ManagingCurrentInventoryServiceImpl implements ManagingCurrentInventoryService {

    @Autowired
    private ManagingCurrentInventoryMapper inventoryMapper;

    @Override
    public Result getInventory() {
        Result result;
        String outputDateString;
        try {
            List<Map<String, Object>> inventory = inventoryMapper.getInventory();
            SimpleDateFormat outputDateFormat = new SimpleDateFormat("yyyy/MM/dd");
            for (int i =0 ;i<inventory.size();i++){
                outputDateString = outputDateFormat.format(inventory.get(i).get("date"));
                inventory.get(i).put("date",outputDateString);
            }
            result = new Result(ResponseCode.OK,"",inventory);
        }catch (Exception e){
            result = new Result(ResponseCode.ServerError,"Server error",null);
            e.printStackTrace();
        }
        return result;
    }
}
