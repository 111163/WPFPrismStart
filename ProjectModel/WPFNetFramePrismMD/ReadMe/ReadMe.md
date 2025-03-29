## 实现Prism接口

## ![Prism接口](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\HelloWPFIndutry.FeiyaoAuto.Young\ProjectModel\WPFNetFramePrismMD\ReadMe\Prism接口.png)



这些接口实现了，基本上框架就搭起来了！

* 导航拦截

  这个非常的有用啊，能不能导航，导航进入之后数据初始化，导航离开之前进行后台线程的关闭啥的，嘎嘎有用！

![导航拦截](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\导航拦截.png)

* Dialog 回传参数

  常用于界面弹框，比如弹出一个登录界面这种，然后你需要回传数据。

![登录窗口](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\登录窗口.png)

![数据回传](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\数据回传.png)

* Dialog 发送消息

  应用场景：在上位机编程中，如果需要发送某个致命消息给到用户。展示的消息支持你定制。类似于Winform的messagebox.show.

  ​                   只是你可以正对这个对话框进行定制。

![对话框](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\对话框.png)

* Dialog 发送消息后，用户点击反馈

![对话框结果获取](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\对话框结果获取.png)



* 发布订阅功能

​      生活场景：你要喝牛奶，然后去订牛奶，牛奶厂就会按照约定的时间，给你送牛奶！

​       Prism的发布订阅

​       发布的消息支持定制，demo定义了IDCode和Message。

​       消息过滤：

​                      类似于订牛奶的场景，你出门旅游不在家，那打电话给牛奶厂，这段时间不要给我送牛奶了！

​                      Prism的消息过滤：

​                                                 Prism不能打电话，所以牛奶厂还是正常送牛奶，只是Prism接到消息过滤了。就好像男女朋友吵架，男人一直道歉，女人说：我不听                      我不听。她过滤了

![发布订阅](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\发布订阅.png)

* 该界面展示了如何使用MaterialDesign的 Card控件，展示你需要展示的内容。

* 我封装的泛型方法，读写json，读写csv数据的展示。

* PS：

  ​     插播个广告：如果你想学习Web开发，建议你找零度编程，他是我见过最优雅的老师。

![文件读写](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\Github\WPFPrismStart\ProjectModel\WPFNetFramePrismMD\ReadMe\文件读写.png)

## 学习资源推荐

### 1.书籍

百度云：通过网盘分享的文件：Book
链接: https://pan.baidu.com/s/1JRifmIyxfHbpk90tlJbPcQ?pwd=bp83 提取码: bp83 
--来自百度网盘超级会员v9的分享

### 2..其他学习资源

2.1 Easyvision 学习套装--》学视觉

![1](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\HelloWPFIndutry.FeiyaoAuto.Young\ProjectModel\WPFNetFramePrismMD\ReadMe\1.png)

2.2 WPF上位机视觉开发

![3](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\HelloWPFIndutry.FeiyaoAuto.Young\ProjectModel\WPFNetFramePrismMD\ReadMe\3.png)

3.3 halcon视觉开发

![2](D:\ZSXQ\HelloFeiyaoAuto\Code\Young\HelloWPFIndutry.FeiyaoAuto.Young\ProjectModel\WPFNetFramePrismMD\ReadMe\2.png)

