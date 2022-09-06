 # SQL關鍵字查詢SP及View
```
SELECT DISTINCT o.name, c.* FROM syscomments c
INNER JOIN sysobjects o ON c.id=o.id
WHERE (o.xtype = 'P'           --查SP
OR o.xtype = 'V')              --查View
And (o.name LIKE '%特定文字%'  --查SP或View名稱
OR c.text LIKE '%特定文字%')   --查SP或View內含文字
```

---
參考
AlenWu的程式學習筆記
https://dotblogs.com.tw/AlenWu_coding_blog/2019/03/12/102752
