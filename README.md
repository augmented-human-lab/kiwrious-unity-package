# kiwrious-unity-package
Kiwrious serial reader implementation as a unity package dependency

# Installation

## Step 1
Update Scripting Runtime Version to `.net 4.x Equivalent` from `Player Settings / Other / Configuration`

## Step 2
Import Kiwrious package

### Unity 2019 or later 
Add below dependency to `Packages/manifest.json`
```json
"com.kiwrious.sdk.unity": "https://github.com/augmented-human-lab/kiwrious-unity-package.git"
```

### Unity 2018 or older
Clone this repository inside `Packages/` folder


# Getting Started

- Add `Kiwrious Reader` prefab into your unity scene from `Packages/kiwrious-unity-package/Prefabs/` 

# Android build

### Modify AndroidManifest.xml
```xml
<manifest>
   <application>
      <activity>
         <!-- add new intent filter -->
         <intent-filter>
            <action android:name="android.hardware.usb.action.USB_DEVICE_ATTACHED" />
         </intent-filter>
         <!-- add new meta data -->
         <meta-data
             android:name="android.hardware.usb.action.USB_DEVICE_ATTACHED"
             android:resource="@xml/device_filter" />
      </activity>
   </application>
</manifest>
```



