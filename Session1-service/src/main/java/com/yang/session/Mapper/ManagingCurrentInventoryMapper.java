package com.yang.session.Mapper;

import com.yang.session.Pojo.OrderItems;
import org.apache.ibatis.annotations.MapKey;
import org.apache.ibatis.annotations.Mapper;

import javax.management.ObjectName;
import java.util.List;
import java.util.Map;

@Mapper
public interface ManagingCurrentInventoryMapper {

    @MapKey("orderID")
    List<Map<String, Object>> getInventory();
}
