# FileupLoad
用.Net MVC實作一個簡單的多檔案上傳

# 說明
```html
<input type="file" name="photos" id="photos" multiple />
```  
做法很簡單，只要在input上加入multiple就可以囉~

# 注意事項
專案建立：建立空白的MVC專案 <br/>
因為是空白的MVC專案，所以在執行專案時會找不到資源，避免每次都要用手輸入路徑，所以要記得去RouteConfig.cs底下修改路徑喔

![image](https://user-images.githubusercontent.com/30917086/101300200-c3a7a000-386f-11eb-8f5f-decc28cea678.png)

# 參考文章
[MVC下的URL Route 設定](https://progressbar.tw/posts/105).<br/>
這是PROGRESSBAR寫關於在MVC下的URL設定
