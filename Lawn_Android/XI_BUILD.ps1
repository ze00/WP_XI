param($SIGNED_APK, $BEFORE_BUILD)
$XI_BUILD_DATE = [System.DateTime]::Now.ToString("yyMMdd")
$XI_VERSION = (Select-Xml -Xpath "//manifest" -Path ../../../Properties\AndroidManifest.xml).Node.versionName
$XI_OUT_APK = "PVZ_WP_XI${XI_VERSION}_${XI_BUILD_DATE}.apk"
$XI_OUT_ZIP = "PVZ_WP_XI${XI_VERSION}_${XI_BUILD_DATE}.zip"
$CHANGELOG = [String]::Join("`n", (cat ..\..\..\Assets\CHANGELOG.txt))
$CHANGELOG_OF_THIS_VERSION_START = $CHANGELOG.IndexOf("XI${XI_VERSION}:")
$CHANGELOG_OF_THIS_VERSION = $CHANGELOG.Substring($CHANGELOG_OF_THIS_VERSION_START, $CHANGELOG.Length - $CHANGELOG_OF_THIS_VERSION_START)
if ($BEFORE_BUILD.Equals("1")) {
  sed -i "s:XI.*_AS:XI${XI_VERSION}_AS:" ../../../Assets\Content\LawnStrings_en.txt
} else {
  cp ../../../$SIGNED_APK $XI_OUT_APK
  # zip -j -P 1065027371 $XI_OUT_ZIP $XI_OUT_APK ../../../Assets/CHANGELOG.txt
  echo "XI${XI_VERSION}版本发布,文件在 *群文件\XI3\${XI_OUT_APK}*
··· 若有操作方法上的问题，先看群公告 ···
··· 若遇到游戏内的BUG，可于740923179群内反馈 ···
··· 大佬的打关教程：https://www.bilibili.com/video/BV1E94y1d7GH ···
$($CHANGELOG_OF_THIS_VERSION.Replace("`t", ''))"

}
