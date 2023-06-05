package com.yang.session.Mapper;

import com.yang.session.Pojo.Order;
import org.apache.ibatis.annotations.Mapper;
import org.apache.ibatis.annotations.Param;

@Mapper
public interface WareHouseManagementMapper {
    Integer getHouseIdByName(Order order);
}
