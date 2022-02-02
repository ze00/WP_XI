param($SIGNED_APK)
$XI_BUILD_DATE = [System.DateTime]::Now.ToString("yyMMdd")
$XI_VERSION = (Select-Xml -Xpath "//manifest" -Path ../../../Properties\AndroidManifest.xml).Node.versionName
$XI_OUT_APK = "PVZ_WP_XI${XI_VERSION}_${XI_BUILD_DATE}.apk"
$XI_OUT_ZIP = "PVZ_WP_XI${XI_VERSION}_${XI_BUILD_DATE}.zip"
cp ../../../$SIGNED_APK $XI_OUT_APK
zip -j -P 1065027371 $XI_OUT_ZIP $XI_OUT_APK ../../../../更新日志.txt
