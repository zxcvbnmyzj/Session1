package com.yang.session.Config.redis;

import com.baomidou.mybatisplus.extension.plugins.pagination.Page;
import com.yang.session.utils.Spring.ApplicationContextHolder;
import org.apache.ibatis.cache.Cache;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.data.redis.core.RedisCallback;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.data.redis.core.ValueOperations;
import org.springframework.validation.annotation.Validated;

import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.ReadWriteLock;
import java.util.concurrent.locks.ReentrantReadWriteLock;

public class RedisCache implements Cache {

    private static final Logger logger = LoggerFactory.getLogger(RedisCache.class);

    private final ReadWriteLock readWriteLock = new ReentrantReadWriteLock();

    private static final long EXPIRE_TIME_IN_MINUTES = 60;

    private String id = "";

    private RedisTemplate redisTemplate;

    public RedisCache(String id){
        if (id == null)
            throw new IllegalArgumentException("Cache instances require an ID");
        this.id = id;
    }

    private RedisTemplate getRedisTemplate(){
        if (redisTemplate == null) {
            redisTemplate = (RedisTemplate) ApplicationContextHolder.getBean("redisTemplate");
        }
        return redisTemplate;
    }

    @Override
    public String getId() {
        return id;
    }

    @Override
    public void putObject(Object key, Object value) {
        RedisTemplate template = getRedisTemplate();
        ValueOperations opsForValue = template.opsForValue();
        opsForValue.set(key, value,EXPIRE_TIME_IN_MINUTES, TimeUnit.SECONDS);
        logger.debug("Put query result to redis");
    }

    @Override
    public Object getObject(Object key) {
        RedisTemplate redisTemplate = getRedisTemplate();
        ValueOperations opsForValue = redisTemplate.opsForValue();
        logger.debug("Get cache query result from redis");
        return opsForValue.get(key);
    }

    @Override
    public Object removeObject(Object key) {
        RedisTemplate redisTemplate = getRedisTemplate();
        redisTemplate.delete(key);
        logger.debug("Remove cache query result from redis");
        return null;
    }

    @Override
    public void clear() {
        RedisTemplate redisTemplate = getRedisTemplate();
        redisTemplate.execute((RedisCallback) connection ->{
            connection.flushDb();
            return null;
        });
        logger.debug("Clear all the cached query result from redis");
    }

    @Override
    public ReadWriteLock getReadWriteLock(){
        return readWriteLock;
    }

    @Override
    public int getSize() {
        return 0;
    }
}
