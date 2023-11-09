# Unity-ML-Agents
<h2>摘要</h2>
這個專題是利用UnityEngine內建的深度學習函式庫ML-Agent來達成自走車以及自動停車。<br><br>
我們所使用的訓練方式是強化學習。如下圖，我們的Agent會隨機的控制我們的車輛，也就是Action。接著程式就會回傳在這一連串的動作裡面得到了多少獎賞與現在的狀態。然後我們使用的算法是ppo(近便政策最佳化)，為一種策略梯度方法，其會直接對策略進行建模並優化。也因此我們沒有一個資料庫去讓他學習，取而代之的是我們訓練之前就設定好的獎勵。ppo有著數據效率低、策略更新穩定的優點，並且常用於強化學習，這也是我們選擇這個算法的主因。
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic1.png?raw=true">
<h2>訓練過程</h2>
https://www.youtube.com/watch?v=upyeNufLjs8
<h2>執行結果</h2>
由於我們的電腦不能開機過長時間，會過熱而關機。
因此原本預計的五千萬步變得只有一千兩百萬多步。但依舊可以看出訓練出來的成效。到停車位時會停止，並且會試圖想要插進去車位裡，並且不會到處亂衝亂撞。<br>
https://www.youtube.com/watch?v=KmknP3KVYIs
<h2>介紹</h2>
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic2.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic3.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic4.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic5.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic6.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic7.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic8.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic9.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic10.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic11.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic12.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic13.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic14.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic15.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic16.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic17.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic18.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic19.png?raw=true">
<img src="https://github.com/LeeMoofon0222/Unity-ML-Agents/blob/main/ReadMe_Picture/Pic20.png?raw=true">
