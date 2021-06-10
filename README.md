# DevFlow
### About us

> &nbsp; :adult: __James Lee__ &nbsp;&nbsp; [Github](https://github.com/devncore-james) &nbsp;&nbsp; james.lee@devncore.org  
> &nbsp; :woman: __Elena Kim__ &nbsp;&nbsp; [Github](https://github.com/devncore-elena) &nbsp;&nbsp; elena.kim@devncore.org

We are very ordinary developers, so we need to communicate with you.   
You can always share information with us and we are looking forward to it.  

##### _Open Source &nbsp; https://github.com/devncore/devncore   &nbsp;&nbsp;   Official Website &nbsp; https://devncore.org_ 

### License Policy
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
[![GPLv3 license](https://img.shields.io/badge/License-GPLv3-blue.svg)](http://perso.crans.org/besson/LICENSE.html)


***
## Overview
- TBD...

<br />

### Wallpaper

![image](https://user-images.githubusercontent.com/52397976/115972634-8deb2580-a58a-11eb-849d-bffbe4375fb9.png)

### QuickBar Switch

![image](https://user-images.githubusercontent.com/52397976/115972804-8f691d80-a58b-11eb-8627-47416f0a9318.png)

...

...


## Application

```csharp
using System;
using System.Windows;
using DevFlow.Data.Theme;
using DevFlow.Main.Views;
using DevFlow.Windowbase.Flowbase;

namespace DevFlow
{
    public class App : FlowApp
    {
        protected override ThemeType OnSetDefaultTheme(ThemeType type) => ThemeType.Dark;

        protected override void OnApplyThemeManager()
        {
            AddTheme(ThemeType.Dark, "Generic.Dark.xaml");
            AddTheme(ThemeType.White, "Generic.White.xaml");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            bool dialogResult = true;

            while (dialogResult)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                main = new MainView();
                main.ShowDialog();
                dialogResult = (bool)main.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
```

## _QuickSlot_

#### QuickSlot : Widget

- ContentTemplate

![image](https://user-images.githubusercontent.com/52397976/121200753-f11ce700-c8ae-11eb-95f0-1932818f87de.png)

## _ColorSpoid_

#### ColorSpoid : Preview

- ContentTemplate

![image](https://user-images.githubusercontent.com/52397976/121201771-bd8e8c80-c8af-11eb-85a2-730d7c4ec7b5.png)

## _Finder_

#### Finder : Explorer

- TitleTemplate
- ContentTemplate

![image](https://user-images.githubusercontent.com/52397976/121201052-2f1a0b00-c8af-11eb-82b2-5b6e1e2b2456.png)

![image](https://user-images.githubusercontent.com/52397976/121374770-255dd980-c97b-11eb-8417-408499728691.png)

```csharp
public class Finder : Explorer
{
    static Finder()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Finder), 
            new FrameworkPropertyMetadata(typeof(Finder)));
    }
}

public class Explorer : FlowWindow
{
    static Explorer()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Explorer), 
            new FrameworkPropertyMetadata(typeof(Explorer)));
    }
}

public class FlowWindow : Window
{

}
```
