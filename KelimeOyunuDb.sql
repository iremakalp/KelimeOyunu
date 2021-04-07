-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kelimeoyunu
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_oyuncular`
--

DROP TABLE IF EXISTS `tbl_oyuncular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_oyuncular` (
  `id` int NOT NULL AUTO_INCREMENT,
  `İsim` varchar(125) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Puan` int NOT NULL,
  `KalanSure` varchar(125) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Tarih` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_oyuncular`
--

LOCK TABLES `tbl_oyuncular` WRITE;
/*!40000 ALTER TABLE `tbl_oyuncular` DISABLE KEYS */;
INSERT INTO `tbl_oyuncular` VALUES (1,'İrem',9800,'02:23','2021-03-28 19:25:14'),(2,'Hasan',0,'00:00','2021-03-28 12:20:50'),(3,'Cansu',7700,'02:30','2021-03-29 15:30:06'),(4,'Ahmet',1300,'03:34','2021-03-29 18:54:23'),(5,'Cihan',2800,'01:28','2021-03-29 22:45:10'),(6,'Cenk',8400,'01 : 23','2021-03-30 17:07:39'),(7,'Efe',2400,'00 : 00','2021-03-30 17:35:57'),(8,'Dicle',900,'03 : 22','2021-03-30 20:46:32'),(9,'Can',400,'03 : 53','2021-04-07 11:58:56'),(10,'Zeynep',800,'03 : 52','2021-04-07 12:00:49');
/*!40000 ALTER TABLE `tbl_oyuncular` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_sorular`
--

DROP TABLE IF EXISTS `tbl_sorular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_sorular` (
  `id` int NOT NULL AUTO_INCREMENT,
  `kelime` varchar(125) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `soru` varchar(125) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sorular`
--

LOCK TABLES `tbl_sorular` WRITE;
/*!40000 ALTER TABLE `tbl_sorular` DISABLE KEYS */;
INSERT INTO `tbl_sorular` VALUES (1,'atık','Hastane, ev, fabrika gibi yerlerden kullanılmış ve kullanıcının artık işine yaramayan maddelerin tümü'),(2,'zeki','Çabuk ve kolay kavrayan, zeyrek'),(3,'yoga','Ruhi yaşam ve bedenle uyumlu olmayı amaçlayan kültürfizik ve felsefe sistemi'),(4,'boşa','Anlamsız ve faydasız yere” anlamında bir söz'),(5,'eğik','Dik veya paralel olmayan doğru'),(6,'yurt','Bakıma ve barınmaya muhtaç bir grup insanın oturduğu, yetiştirildiği veya bakıldığı kurum'),(7,'ajans','Haber toplama, yayma ve üyelerine dağıtma işiyle uğraşan kuruluş'),(8,'robot','Gelişen teknolojiyle birçok alanda insanın yerini alabileceği düşünülen elektromekanik araç'),(9,'sahil','Karanın deniz boyunca uzanan bölümü'),(10,'tahta','Çeşitli işlerde kullanılmak üzere hazırlanmış, işlenmiş ağaç parçası'),(11,'rakun','Kuzey Amerika’ya özgü, kafası tilkiye benzeyen, uzun kuyruğu alaca halkalı olan kürklü hayvan'),(12,'kobay','Bir deneyin edilgen katılımcısı'),(13,'zamane','Yakınma ve hafifseme yoluyla “Şimdiki devir” anlamında kullanılan sözcük'),(14,'yüksük','Dikiş nakış işlerinde kullanılan parmak korumalığı'),(15,'safran','Canlı bir sarı tonunu da adıyla niteleyen, dünyanın en pahalı baharatı'),(16,'zürafa','Birçok kültürde zarafet ve inceliği temsil eden hayvan'),(17,'şenlik','Coşkulu, toplumsal eğlence'),(18,'davetli','Bir yere ağırlanmak üzere çağrılmış kişi'),(19,'alçıpan','Duvar veya asma tavan yapımında kullanılan, iki tarafı kağıt kaplı olan levha'),(20,'didinme','Çok zorluk çekerek sürekli çalışma'),(21,'cıvıltı','Kuş ezgisi'),(22,'piramit','İnsanlık tarihindeki en görkemli anıt mezar türü'),(23,'pastane','Tatlı ve hamur işi dükkanı'),(24,'yığılmak','Kendini tutamayıp çökmek, bayılıp düşmek'),(25,'zararına','“Üretim fiyatının altında yapılan satışları” niteleyen söz'),(26,'senfonik','“Orkestra için bestelenmiş, birkaç bölümden oluşan uzun müzik eserleriyle ilgili” anlamında bir söz'),(27,'acıhaber','Kötü bir olayı duyuran bilgi'),(28,'akrostiş','Her dizenin ilk harfi yukarıdan aşağıya doğru okunduğunda ortaya bir söz çıkacak biçimde düzenlenmiş manzume'),(29,'pazarlık','Ekonomik ikna sanatı'),(30,'rolmodeli','Örnek ve feyzalınan, öykünülen, taklit edilen kişi'),(31,'tatlısert','“Ne çok katı ne de çok yumuşak” anlamında bir tabir'),(32,'zikretmek','“Adını söylemek, sözünü söylemek, anmak” anlamlarında bir tabir'),(33,'sürmanşet','Gazetelerin birinci sayfasındaki logonun üzerinde kullanılan başlık'),(34,'gökkuşağı','Yağmur ve Güneşin semavi ışık oyunu'),(35,'sonsuzluk','Arapça kökenli “Ebet” sözünün Türkçe kökenli karşılığı'),(36,'dilimlemek','Bir bütünü keserek ince ve yassı parçalara ayırmak'),(37,'ruhsağlığı','Psikolojik denge'),(38,'rüzgargülü','Esintinin yönünü, bazen de adını gösteren levhalara verilen ad'),(39,'karşılaşma','Maç sözcüğünün eş anlamlısı'),(40,'hedefkitle','Verilmek istenen mesajın ulaşması istenen grup veya topluluk'),(41,'ihmaletmek','Gereken ilgiyi göstermemek, savsaklamak, boşlamak'),(42,'ataş','İnce bir teli üç kez iç içe bükerek elde edilen bir kırtasiye gereci'),(43,'Bölü','Bayağı kesirlerde pay ile payda arasına konulan yatay çizginin okunuşu'),(44,'inek','Genç olanlarına “Düve” denen hayvan'),(45,'saten','“Atlas” da denen kumaş türü'),(46,'takat','Bir şeyi yapabilme, başarabilme gücü, derman'),(47,'nevruz','Eski takvimlere göre yılın ve baharın ilk günü sayılan Martın yirmi birine rastlayan gün'),(48,'sadaka','Çaresizlikten dolayı alınan ve karşılığı hayır duası olarak ödenen para'),(49,'ittihat','“Birleşme, birlik oluşturma” anlamına gelen, meşrutiyet dönemindeki bir cemiyetin de iki ilkesinden biri olan söz'),(50,'sakınha','Yapılması istenmeyen bir davranışı engellemek için söylenen, iki farklı ünlemden oluşan sözcük dizisi'),(51,'yakınlık','Duygusal bağ veya akrabalık ilişkisi'),(52,'arasınav','Üniversite ve yüksekokullarda yarıyıl içinde yapılan yoklama, vize'),(53,'dekanlık','Fakülte başkanının makamı'),(54,'atıvermek','Bir cismi bir yöne doğru ansızın, çabucak fırlatmak'),(55,'Bitkiçayı','Ihlamur, Papatya, Kuşburnu gibi ürünlerden elde edilen sıcak içeceklerin genel adı'),(56,'imdatfreni','Tehlike anında yolcuların aracı durdurabilmesi için görünür bir yerde bulunan düzenek'),(57,'altıncıhis',' Görmeden, duymadan, koklamadan, tatmadan, dokunmadan algılanan sezi');
/*!40000 ALTER TABLE `tbl_sorular` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-07 14:40:58
