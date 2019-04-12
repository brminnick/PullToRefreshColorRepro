# PullToRefreshColorRepro
Xamarin.Forms reproduction sample showing RefreshControlColor bug on iOS

## Reproduction Steps

1. Open PullToRefreshColorRepro.sln
2. Set PullToRefreshColorRepro.iOS as the Startup Project
3. Build/deploy PullToRefreshColorRepro.iOS to an iOS Device
    - Note: I am using iPhone XR iOS 12.2 Simulator
4. Wait for the app launch on the iOS device
    - When the app launches, `ListView.BeginRefresh()` is automatically triggered in `ListViewPage.OnAppearing()`
5. During the automatic pull-to-refresh, note that `RefreshControlColor` is the default Color, not the requested color
6. Wait for the automatic pull-to-refresh to finish
7. Manually trigger a pull-to-refresh by tap-and-draging the UI from top to bottom
    - During the manual refresh, note that `RefreshControlColor` is the requested color, `Color.Cyan`

![Reproduction Video](https://user-images.githubusercontent.com/13558917/56069815-a12b4f80-5d39-11e9-94b5-8998bde4d78b.gif)


## Environment

=== Visual Studio Enterprise 2019 for Mac ===

Version 8.0.2 (build 23)
Installation UUID: ddef6b6c-60a7-41bb-86fe-46d627a870b6
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.6.0.2 (d16-0 / 040682909)

	Package version: 518010003

=== Mono Framework MDK ===

Runtime:
	Mono 5.18.1.3 (2018-08/fdb26b0a445) (64-bit)
	Package version: 518010003

=== NuGet ===

Version: 4.8.2.5835

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.0.0-preview3-27503-5
	3.0.0-preview-27324-5
	3.0.0-preview-27122-01
	2.2.0
	2.2.0-preview3-27014-02
	2.1.9
	2.1.8
	2.1.6
	2.1.2
	2.1.1
	2.0.6
	2.0.5
	1.1.10
	1.0.13
SDK: /usr/local/share/dotnet/sdk/2.2.100/Sdks
SDK Versions:
	2.2.100
	2.1.505
	2.1.504
	2.1.500
	2.1.302
	2.1.301
	2.1.101
	2.1.4
	1.1.11
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/5.18.1/lib/mono/msbuild/15.0/bin/Sdks

=== Xamarin.Profiler ===

Version: 1.6.9
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Xamarin.Android ===

Version: 9.2.0.5 (Visual Studio Enterprise)
Android SDK: /Users/bramin/Library/Android/sdk
	Supported Android versions:
		6.0 (API level 23)
		7.0 (API level 24)
		7.1 (API level 25)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 28.0.2
SDK Build Tools Version: 28.0.3

Build Information: 
Mono: mono/mono/2018-08-rc@5ad371dab1b
Java.Interop: xamarin/java.interop/d16-0@c987483
LibZipSharp: grendello/LibZipSharp/master@44de300
LibZip: nih-at/libzip/rel-1-5-1@b95cf3f
MXE: xamarin/mxe/xamarin@b9cbb535
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.26.0@325e91a
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-0@0a7edd6

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android Device Manager ===

Version: 1.2.0.14
Hash: 86df26f
Branch: remotes/origin/d16-0
Build date: 2019-04-05 16:58:56 UTC

=== Apple Developer Tools ===

Xcode 10.2 (14490.120)
Build 10E125

=== Xamarin.Mac ===

Version: 5.8.0.0 (Visual Studio Enterprise)
Hash: 0aa84521
Branch: d16-0
Build date: 2019-04-02 16:01:19-0400

=== Xamarin.iOS ===

Version: 12.8.0.0 (Visual Studio Enterprise)
Hash: 0aa84521
Branch: d16-0
Build date: 2019-04-02 16:01:19-0400

=== Xamarin Designer ===

Version: 4.17.4.418
Hash: 3d086e814
Branch: remotes/origin/d16-0
Build date: 2019-04-01 09:20:10 UTC

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 800020023
Git revision: c576bb008dfe54cdcf596237e09564ebd2da4343
Build date: 2019-04-06 10:06:46+00
Build branch: master
Xamarin extensions: 2c996830618e7cb8e8be97984d643eb86f122e8d

=== Operating System ===

Mac OS X 10.14.4
Darwin 18.5.0 Darwin Kernel Version 18.5.0
    Mon Mar 11 20:40:32 PDT 2019
    root:xnu-4903.251.3~3/RELEASE_X86_64 x86_64

=== Enabled user installed extensions ===

NuGet Package Management Extensions 0.17

