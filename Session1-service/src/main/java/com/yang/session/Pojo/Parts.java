package com.yang.session.Pojo;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Repository;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Repository
public class Parts {
    private Integer pid;

    private String PartName;

    private Integer EffectiveLife;

    private Integer BatchNumberHasRequired;

    private Integer MinimumAmount;
}
