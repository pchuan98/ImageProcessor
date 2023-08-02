# OpenCV2

## 图像数据类型

| 数据类型		| 大小（字节） | 最小值						| 最大值					| CV2类型	|
|---------------|------------|--------------------------|-----------------------|-----------|
| sbyte         | 1          | -128                     | 127					|CV_8S		|
| byte          | 1          | 0                        | 255					|CV_8U		|
| short         | 2          | -32,768                  | 32,767				|CV_16S		|
| ushort        | 2          | 0                        | 65,535				|CV_16U		|
| int           | 4          | -2,147,483,648           | 2,147,483,647			|CV_32S		|
| float         | 4          | -3.402823e38             | 3.402823e38			|CV_32F		|
| double        | 8          | -1.79769313486232e308    | 1.79769313486232e308	|CV_64F		|


## 可用数据类型比较
|数据类型  	 | CV2类型			 |
|------------|-------------------|
|byte        |CV_8SC1,CV_8UC1    |
|sbyte       |CV_8SC1,CV_8UC1    |
|short       |CV_16SC1,CV_16UC1  |
|ushort      |CV_16SC1,CV_16UC1  |
|int         |CV_32SC1           |
|float       |CV_32FC1           |
|double      |CV_64FC1           |
|Point       |CV_32SC2           |
|Point2f     |CV_32FC2           |
|Point2d     |CV_64FC2           |
|Point3i     |CV_32SC3           |
|Point3f     |CV_32FC3           |
|Point3d     |CV_64FC3           |
|Size        |CV_32SC2           |
|Size2f      |CV_32FC2           |
|Size2d      |CV_64FC2           |
|Rect        |CV_32SC4           |
|Rect2f      |CV_32FC4           |
|Rect2d      |CV_64FC4           |
|Vec2b       |CV_8UC2            |
|Vec2s       |CV_16SC2           |
|Vec2w       |CV_16UC2           |
|Vec2i       |CV_32SC2           |
|Vec2f       |CV_32FC2           |
|Vec2d       |CV_64FC2           |
|Vec3b       |CV_8UC3            |
|Vec3s       |CV_16SC3           |
|Vec3w       |CV_16UC3           |
|Vec3i       |CV_32SC3           |
|Vec3f       |CV_32FC3           |
|Vec3d       |CV_64FC3           |
|Vec4b       |CV_8UC4            |
|Vec4s       |CV_16SC4           |
|Vec4w       |CV_16UC4           |
|Vec4i       |CV_32SC4           |
|Vec4f       |CV_32FC4           |
|Vec4d       |CV_64FC4           |
|Vec6b       |CV_8UC(6)          |
|Vec6s       |CV_16SC(6)         |
|Vec6w       |CV_16UC(6)         |
|Vec6i       |CV_32SC(6)         |
|Vec6f       |CV_32FC(6)         |
|Vec6d       |CV_64FC(6)         |