# Thinkpad 自动键盘背光
汉化并修正了一些问题，相信应该在绝大多数Thinkpad带背光机型上可用。

一看就会用，有鼠标或键盘活动时不会延迟自动关闭键盘背光，当任意键按下，背光按设置亮度启动。
可以加入开机启动，本程序需要安装.NET Framework 4.8 (windows 10/11 默认应该自带已安装）
程序启动后，在任务栏右下角生成图标，右键单击可手工开启/关闭键盘背光，双击进入自动背光设置：

<img src="thinkpad-backlight.png" />
注意：本程序如不能正常启动，请安装下面任意包：

注意：本程序如不能正常启动，请安装下面任意一个包：

- [联想电脑管家](https://guanjia.lenovo.com.cn/moreversions.html) （推荐, 如失效，请去[联想官网](https://www.lenovo.com.cn/)自行搜索)
- [联想电源管理驱动](https://think.lenovo.com.cn/support/driver/driverdetail.aspx?DEditid=105725&docTypeID=DOC_TYPE_DRIVER&driverID=undefined&treeid=3108076&args=%3Fyt%3Dpt%26categoryid%3D3108076%26CODEName%3D20AK%26SearchType%3D1%26wherePage%3D2%26os%26from%3Dthink%26osid%3D233%26SearchNodeCC%3DThinkPad+X240s) (如失效，请去[联想官网](https://www.lenovo.com.cn/)自行搜索）
- [Lenovo vantage](https://mclub.lenovo.com.cn/thread-5425285-1-1.html)  (如失效，请去[联想官网](https://www.lenovo.com.cn/)自行搜索）
Lenovo vantage 链接：https://pan.baidu.com/s/1eDJ58KQLjiaMF6m_SoH3OA
提取码：ssk2

并确保能找到下面类似任意一个目录 (且在目录中能找到Keyboard_Core.dll和Contract_Keyboard.dll)

C:\ProgramData\Lenovo\ImController\Plugins\ThinkKeyboardPlugin\x86
C:\Program Files (x86)\Lenovo\PCManager\5.1.30.9202\Modules\Setings\x86

如果Keyboard_Core.dll和Contract_Keyboard.dll不是在上述类似的两个目录中，
需要用写字板打开并编辑Thinkpad-Backlight.exe.config 找到代码
```
            <setting name="DllPath" serializeAs="String">
                <value>C:\ProgramData\Lenovo\ImController\Plugins\ThinkKeyboardPlugin\x86</value>
            </setting>
```
将<value></value>中的路径替换成你所找到的目录路径。
如果上述两个dll文件不在同一目录，拷贝放置这两个dll文件在同一目录中，并修改该目录路径在<value></value>中即可。

# 常见问题：

- 自动背光程序开启后，希望不要在屏幕上出现黑色的背光亮度开/关图标，如何解决？

Windows键+R > 运行 > services.msc
打开服务管理器，找到有一个名为Lenovo Hotkey Client Loader 的服务，把它禁止就可以了，这样不论手工还是通过这个程序自动调节键盘背光，都不会显示那个键盘背光亮度开/关图标的。
关闭这个热键服务后，可能会失效些不常用的F功能键，看你自已选择了。

- 应用程序无法启动，报错 - ”配置系统未能初始化“

参见2楼修改.config配置文件，可能修改时产生了格式错误，该文件类似XML标记格式（不懂的可自行百度）。

- 应用程序无法启动，报错 - ”参数计数不匹配“

可能是Thinkpad键盘驱动库文件不兼容此程序，遇到此类问题，请参考上述説明，找到Keyboard_Core.dll和Contract_Keyboard.dll，附件留言，等待楼主修复。

# Lenovo files needed
此实用程序需要 Lenovo 文件“Keyboard_Core.dll”和“Contract_Keyboard.dll”，由于版权原因，这些文件未包含在此存储库或软件版本中。 如果程序退出时提示未找到这些文件之一，请在计算机上找到“ThinkKeyboardPlugin”文件夹（该文件夹应包含这两个文件）并在 app.config 中编辑以下设置：

            <setting name="DllPath" serializeAs="String">
                <value>C:\ProgramData\Lenovo\ImController\Plugins\ThinkKeyboardPlugin\x86</value>
            </setting>
			
如果您没有此文件夹，a) 确保您安装了 Lenovo 实用程序，或者 b) 出现紧急情况。
			
# Usage
This utility adds a system tray icon. Double click the icon to open the settings, or right click for a menu.

![Settings](Settings.png)

# Build instructions
The project targets .NET 4.8 so you will need the .NET 4.8 Targetting Pack installed, or you can downgrade the target to an older framework.
