# Thinkpad 自动键盘背光
汉化并修正了一些问题，相信应该在绝大多数Thinkpad带背光机型上可用。

一看就会用，有鼠标或键盘活动时不会延迟自动关闭键盘背光，当任意键按下，背光按设置亮度启动。
可以加入开机启动，本程序需要安装.NET Framework 4.8 (windows 10/11 默认应该自带已安装）
程序启动后，在任务栏右下角生成图标，右键单击可手工开启/关闭键盘背光，双击进入自动背光设置：

<img src="thinkpad-backlight.png" />
注意：本程序如不能正常启动，请安装下面任意包：

~ 联想管家
~ 联想电源管理驱动
~ Lenovo vantage

并确保能找到下面类似任意一个目录 (且在目录中能找到Keyboard_Core.dll和Contract_Keyboard.dll)

C:\ProgramData\Lenovo\ImController\Plugins\ThinkKeyboardPlugin\x86
C:\Program Files (x86)\Lenovo\PCManager\5.1.30.9202\Modules\Setings\x86

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
