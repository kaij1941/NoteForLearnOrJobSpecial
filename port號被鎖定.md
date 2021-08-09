# port號被鎖定
## 首次遭遇情境: 
在 使用dockerDestop 設定 Hyper-V 會大量鎖定port 使得 某些 伺服器的預設port號無法使用
### 確認鎖定port
進入cmd => 指令
````
netsh int ipv4 show excludedportrange protocol=tcp
````
### 關閉 Hyper-V 
進入cmd =>(以系統管理員身分執行)指令 
````
dism.exe /Online /Disable-Feature:Microsoft-Hyper-V
````
### 重啟winnat服務 (重整鎖定狀況)
進入cmd =>(以系統管理員身分執行)指令
````
net stop winnat
net start winnat
````
### 如要設定自己的保留port
進入cmd =>(以系統管理員身分執行)指令
````
netsh int ipv4 add excludedportrange protocol=tcp numberofports=1 startport=保留port號
````
### 如要刪除自己的保留port
進入cmd =>(以系統管理員身分執行)指令
````
netsh int ipv4 delete excludedportrange protocol=tcp numberofports=1 startport=保留port號
````

以上解決方式 參考
1. The Will Will Web 保哥 -Windows 10 無法 LISTEN Port 4200 與 Port 3000 的靈異事件整理
https://blog.miniasp.com/post/2019/03/31/Ports-blocked-by-Windows-10-for-unknown-reason
2. 黑暗執行緒 -【茶包射手日記】ASP.NET Core Kestrel 網站無權繫結錯誤與 Windows 10 Port 限制
https://blog.darkthread.net/blog/kestrel-binding-failure/
