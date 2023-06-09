#include <OneWire.h>
#include <DallasTemperature.h>
#include <WiFi.h>
//----------------------------


namespace pin {
const byte tds_sensor = A0; // TDS
const byte one_wire_bus = 33; // Temp.Sensor
}
 
namespace device {
float aref = 4.3;
}
 
namespace sensor {
float ec = 0;
unsigned int tds = 0;
float waterTemp = 0;
float ecCalibration = 1;
int pause = 5000;  
  unsigned long start_time; 
}
 
OneWire oneWire(pin::one_wire_bus);
DallasTemperature dallasTemperature(&oneWire);

const char* ssid     = "Totalplay-3077";
const char* password = "3077C654YD26Y9d3";

WiFiServer server(80);
String Ip;

 const int potPin = 34; // Sensor pH
float ph;
float Value = 0;
 String IpAddress3String(const IPAddress& ipAddress)
 {
  return String(ipAddress [0] ) + String(".") +\
  String (ipAddress[1]) + String(".") +\
  String (ipAddress[2]) + String(".") +\
    String (ipAddress[3]) + String(".") +\
  String (ipAddress[4])  ;
 }
void setup() {
  Serial.begin(115200);
  
  dallasTemperature.begin();

  
  
   

  delay(10);
   Serial.println();
    Serial.println();
    Serial.print("Connecting to ");
    Serial.println(ssid);
   WiFi.begin (ssid, password);
  
  while (WiFi.status() != WL_CONNECTED) {
        delay(500);
        Serial.print(".");
         
    }
//Ip = IpAddress3String( WiFi.localIP() );
    Serial.println("");
    Serial.println("WiFi connected.");
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP());
    
    server.begin();
  delay(1000);
  
  
}
 
 int value=0;
void loop() {
         

/*if(!client){
   return;
}

Serial.println("Nuevo cliente...");
while (!client. available ()){ //espera a un cliente diponible
   delay (1);
}
*/
//////////////////////////////////////

/////////////////////////////////

  ///////////////////////
  Value= analogRead(potPin);
 Serial.print(" pH: ");
 float voltage=Value*(3.3/4092.0);
 ph=(3.3*voltage);
 Serial.println(ph);
 dallasTemperature.requestTemperatures();
  sensor::waterTemp = dallasTemperature.getTempCByIndex(0);
  float rawEc = analogRead(pin::tds_sensor) * device::aref / 1024.0; 
  float temperatureCoefficient = 1.0 + 0.02 * (sensor::waterTemp - 25.0); 
  sensor::ec = (rawEc / temperatureCoefficient) * sensor::ecCalibration; 
  sensor::tds = (133.42 * pow(sensor::ec, 3) - 255.86 * sensor::ec * sensor::ec + 857.39 * sensor::ec) * 0.5; 
  Serial.print(F("TDS:")); Serial.println(sensor::tds);
  Serial.print(F("EC:")); Serial.println(sensor::ec, 2);
  Serial.print(F("Temperatura:")); Serial.println(sensor::waterTemp,2);
  Serial.println("-------------------------------");
  delay(5000);
 
///////////////////////////////////////////////////////////////////////////////////////////
WiFiClient client = server.available (); 
  if (client) {                            
    Serial.println("New Client.");           
    String currentLine = "";               
    while (client.connected()) {            
      if (client.available()) {             
        char c = client.read();             
        Serial.write(c);                    
        if (c == '\n') {                    r

          
          if (currentLine.length() == 0) {
            
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
          
            client.println();
              client.println("<center>");
              client.println("<h2>PH = "+ String(ph) + "</h2>");
              client.println("<h2>TDS = "+ String(sensor::tds) + "</h2>");
              client.println("<h2>EC = "+ String(sensor::ec, 2) + "</h2>");
              client.println("<h2>Temperatura = "+ String(sensor::waterTemp, 2) + "°C</h2>");
              client.println("</center>");

                client.println("</div></center></body></html>");
client.println();

            
            client.println();
           
            break;
          } else {    
            currentLine = "";
          }
        } else if (c != '\r') {  
          currentLine += c;    
        }
      }
    }
    
    client.stop();
    Serial.println("Client Disconnected.");
  }
}