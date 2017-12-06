Imports System.Net.WebClient
'Imports System.Net.Http.Headers
'Imports System.Net.Http.Formatting

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters


Public Class CryptoCompareMinAPI
    Public Structure PriceInfo
        Dim USD As Double
    End Structure

    Public Structure CoinSnapshot
        Dim Response As String
        Dim Message As String
        Dim Data As CoinSnapshotData
        Dim Type As String
    End Structure

    Public Structure CoinSnapshotData
        Dim Algorithm As String
        Dim ProofType As String
        Dim BlockNumber As Long
        Dim NetHashesPerSecond As Long
        Dim TotalCoinsMined As Long
        Dim BlockReward As Long
        Dim AggregatedData As AggregatedData
        Dim Exchanges As Exchanges()
    End Structure

    Public Structure AggregatedData
        Dim TYPE As Long
        Dim MARKET As String
        Dim FROMSYMBOL As String
        Dim TOSYMBOL As String
        Dim FLAGS As Long
        Dim PRICE As Double
        Dim LASTUPDATE As Long
        Dim LASTVOLUME As Double
        Dim LASTVOLUMETO As Double
        Dim LASTTRADEID As String
        Dim VOLUMEDAY As Double
        Dim VOLUMEDAYTO As Double
        Dim VOLUME24HOUR As Double
        Dim VOLUME24HOURTO As Double
        Dim OPENDAY As Double
        Dim HIGHDAY As Double
        Dim LOWDAY As Double
        Dim OPEN24HOUR As Double
        Dim HIGH24HOUR As Double
        Dim LOW24HOUR As Double
        Dim LASTMARKET As String
    End Structure

    Public Structure Exchanges
        Dim TYPE As Long
        Dim MARKET As String
        Dim FROMSYMBOL As String
        Dim TOSYMBOL As String
        Dim FLAGS As Long '"4"
        Dim PRICE As Double '"3.4573"
        Dim LASTUPDATE As Long '"1512507746"
        Dim LASTVOLUME As Double '"78.687699"
        Dim LASTVOLUMETO As Double '"272.0469817527"
        Dim LASTTRADEID As String '"109726272"
        Dim VOLUME24HOUR As Double '"65301885.508724995"
        Dim VOLUME24HOURTO As Double '"203794462.21036872"
        Dim OPEN24HOUR As Double '"2.6935"
        Dim HIGH24HOUR As Double '"3.589"
        Dim LOW24HOUR As Double '"2.095"
    End Structure

    Public Function GetSnapshotCoinPair(Optional FromCoin As String = "IOT", Optional ToCoin As String = "USD") As CoinSnapshot
        Dim wc As New Net.WebClient()
        Dim t As New IO.StreamReader(wc.OpenRead("https://www.cryptocompare.com/api/data/coinsnapshot/?fsym=" & FromCoin & "&tsym=" & ToCoin))
        Dim retVal As New CoinSnapshot
        Dim jsonString As String = t.ReadToEnd()
        '//Convert the JSON back to a structure
        retVal = JsonConvert.DeserializeObject(jsonString, GetType(CoinSnapshot))
        t.Close()
        t.Dispose()
        wc.Dispose()
        Return retVal
    End Function

    Public Function GetPriceCoinPair(Optional FromCoin As String = "IOT", Optional ToCoin As String = "USD") As Generic.Dictionary(Of String, Double)
        Dim jsonString As String
        Dim t As IO.StreamReader
        Try
            Dim wc As New Net.WebClient()
            t = New IO.StreamReader(wc.OpenRead("https://min-api.cryptocompare.com/data/price?fsym=" & FromCoin & "&tsyms=" & ToCoin))
            'Dim retVal As Object
            '//Convert the JSON back to a structure
            jsonString = t.ReadToEnd()
            t.Close()
            t.Dispose()
            wc.Dispose()
        Catch
            jsonString = "{""ERROR"":0.00}"
        End Try
        Dim jso As Newtonsoft.Json.Linq.JObject
        Dim retVal As New Generic.Dictionary(Of String, Double)
        jso = JsonConvert.DeserializeObject(jsonString, GetType(Object))
        Dim jsp As Newtonsoft.Json.Linq.JProperty = jso.First
        Dim jval As Newtonsoft.Json.Linq.JValue = jsp.Value
        retVal.Add(jsp.Path, jval.Value)
        Return retVal
    End Function




End Class
