C#编写

# 功能说明

由于QQ邮箱中转站和超星云盘都无法在PC端直接生成分享链接，每次获取分享链接都还需要去手机端操作，比较繁琐，要分享的文件一多更让人头皮发麻，于是写了这个小程序自用。

功能实现的过程很菜鸡，以后考虑优化代码。

1. 将QQ邮箱中转站的下载链接转换为分享链接
2. 通过模拟键盘操作，获取超星云盘文件的文件ID，靠此生成分享链接

![](https://raw.githubusercontent.com/axutongxue/img/master/20190504190501.png)

# 使用说明

在QQ邮箱中转站右键下载链接——复制链接地址，然后点击软件直接转换即可。

![](https://raw.githubusercontent.com/axutongxue/img/master/20190504183012.png)

超星云盘需要用浏览器的F12（开发者工具），获取需要分享的文件的class字段，再点击软件获取分享链接。

具体操作是：F12——选择网页元素——双击右方网页源代码——默认就会选中class=“fileName node_name_xxxxxx”字段，这时再用程序转换即可。

![](https://raw.githubusercontent.com/axutongxue/img/master/20190504190725.png)

同时软件可以实现模拟键盘来实现上方操作：

将鼠标放在超星云盘的文件名上（注意，一定要放在文件名上），再按Ctrl+Q，即会自动模拟上方的操作，并生成分享链接。


