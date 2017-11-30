## Unity AR TowerDefenseセットアップ&運用マニュアル

● 必要なもの
* PC1台(windows10/64bit/メモリ8gb動作確認済)   
* Webカメラ 
* Unity(version 2017.1.0)   
* ARマーカー(3枚)
  
● 準備手順  
1. Unityのダウンロードとアカウント登録  
2. ゲームのプロジェクトのダウンロード  
3. ゲームの起動までの手順  
4. 準備と遊び方
## 1. Unityのダウンロードとアカウント登録
### 1-1. Unityのダウンロード
「<https://unity3d.com/jp/get-unity/download>」左記のURLページのリソース欄にある過去のバージョンのUnityをクリックしてダウンロードページに移動。「Unity2017.x」を選択し一覧にある「Unity2017.1.0」の「ダウンロード(Win)→Unityインストーラー」をクリックしてダウンロードする。  
### 1-2. Unityのインストール  
    ダウンロードしたファイルを実行してUnityをインストール。
### 1-3. Unityアカウントの作成  
    インストール終了後、Unityを起動する。ログイン画面に移動するので「create one」をクリックしてアカウントを作成する。すでにアカウントを持っている場合は新しく作成する必要はない。
### 1-4. Unityにログイン  
    アカウント作成後、ログインするとLicenseManagement選択画面が出ているのでPersonalを選択するとProjects選択画面に移動する。  
## 2. ゲームのプロジェクトダウンロード  
    nasubichan(150.89.234.253)にアクセスして(nasubichan/igakilab/shared/eins/kitasai_Game)の中にあるtenjigo.unitypackageをダウンロードする。  
## 3. ゲーム起動までの手順  
### 3-1. プロジェクト作成
    Projects選択画面から「new project」を選択、Project nameを「AR TOWER DEFENSE」にして作成する。
### 3-2. パッケージをインポート  
    手順2でダウンロードしたtenfigo.unitypackageを開きインポートする。
### 3-3. シーンの統合を行う  
    開発画面左下のAssetsフォルダの中にあるSceneを開く。メニューバーのFile→Build&Settingsを選択。Settings画面が表示されたら画面上部にあるScenes In Buildと書かれた四角の枠に先ほど開いたScene内のnew_titleとMainをドラッグ&ドロップする。この時new_titleが必ず上になるようにする。その後Buildを選択し適当な場所に保存する。Build終了後Build Settings画面を閉じる。  
### 3-4. タイトルシーンからゲームスタート  
    Sceneフォルダのnew_titleをダブルクリックしてタイトルシーンを開く。この画面で上部の「▶︎」ボタンをクリックするとゲームを開始することができる。  
## 4. 準備と遊び方
    カメラにマーカーを読み込ませて遊ぶゲームです。カメラの配置の仕方はnasubichanの(nasubichan/igakilab/shared/eins/カメラ配置画像)を参考にして下さい。まずゲーム画面の拡大化を行います。ゲーム画面の拡大化の方法についてはnasubichanの(nasubichan/igakilab/shared/eins/画面の拡大化)を参考にして下さい。セットアップマニュアル3-4同様ゲームを開始する。最初にモード選択画面が表示されるのでnormal(easyは使わない)を選択し、Mainシーンに移動する。家(漢字マーカー(艦))及び戦車2台(漢字マーカー(鸞と鷹)をカメラに読み込ませたらゲームを画面右上のスタートボタンをクリックしてゲームスタート。戦車のマーカーを動かして家に向かって来る敵を倒し、家を守りきればゲームクリアです。スコアを記録してランキングを作りましょう。
