
'換行
Dim testWord as string =  "第一行文字" & vbCrLf & "第二行文字"
'大量文字(跨行文字類似C# 的@)
dim TestArea as string =<s><![CDATA[
                                           1.大量文字一 
                                           2.大量文字二
                            ]]></s>
'
'-------------以下為結果
'換行
'第一行文字
'第二行文字
'大量文字
'1.大量文字一 
'2.大量文字二
