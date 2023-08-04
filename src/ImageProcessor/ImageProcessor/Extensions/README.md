## SpatialExtension

### Inversion

灰度变换 - 反转

$s = L - 1 -r$

设原始图像为 $I(x, y)$，阈值为 $T$，范围下界为 $L_{\text{lower}}$，范围上界为 $L_{\text{upper}}$。

阈值掩码：

```math
\text{ThresholdMask}(x, y) = \begin{cases} 255, & \text{if } I(x, y) \geq T \\ 0, & \text{otherwise} \end{cases}
```

范围掩码：

```math
\text{RangeMask}(x, y) = \begin{cases} 255, & \text{if } L_{\text{lower}} \leq I(x, y) \leq L_{\text{upper}} \\ 0, & \text{otherwise} \end{cases}
```

合并掩码：

```math
\text{Mask}(x, y) = \text{RangeMask}(x, y) \land \text{ThresholdMask}(x, y)
```

取反操作：

```math
\text{Result}(x, y) = \begin{cases} 255 - I(x, y), & \text{if } \text{Mask}(x, y) = 255 \\ I(x, y), & \text{otherwise} \end{cases}
```
