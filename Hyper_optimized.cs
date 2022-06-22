// using System;
// using System.Linq;

// public static class teste
// {
//     public static string whatDay(int day) => day switch
//     {
//         > 1 => "Monday",
//         _ => "today"
//     };
// }


// public static class TelemetryBuffer
// {
//     public static byte[] ToBuffer(long reading)
//     {
//         byte[] payloadBytes = BitConverter.GetBytes(reading); // aqui temos um array com 8 elementos xx-xx-xx-xx-xx-xx-xx-xx
//         byte[] buffer = new byte[_bufferSize];                //criando um array com tamanho 9
//         PayloadType payloadType = GetPayloadType(reading);    // tem sobrecarga, aqui usamos a com long, com base no valor colocado vamos dizer a qual type esse valor se encaixa, dai retorna um enum sendo o tipo 
//         int payloadSize = PayloadSize(payloadType);           //com base no tipo iremos determinar o tamanho do array
//         buffer[0] = ByteCode(payloadType, payloadSize);       //
//         Buffer.BlockCopy(payloadBytes, 0, buffer, 1, payloadSize);
//         return buffer;
//     }
//     public static long FromBuffer(byte[] buffer) => GetPayloadType(buffer[0]) switch
//     {
//         PayloadType._long => BitConverter.ToInt64(buffer, 1),
//         PayloadType._int => BitConverter.ToInt32(buffer, 1),
//         PayloadType._short => BitConverter.ToInt16(buffer, 1),
//         PayloadType._ushort => BitConverter.ToUInt16(buffer, 1),
//         PayloadType._uint => BitConverter.ToUInt32(buffer, 1),
//         _ => 0
//     };
//     #region Fixed values 

//     private static int _bufferSize = 9; //1 byte prefix + 8 bytes payload
//     enum PayloadType
//     {
//         _long,
//         _ulong,
//         _int,
//         _uint,
//         _short,
//         _ushort,
//         invalid
//     }
//     #endregion
//     #region Helper methods
//     private static PayloadType GetPayloadType(long value) => value switch
//     {
//         > uint.MaxValue => PayloadType._long,
//         > int.MaxValue => PayloadType._uint,
//         > ushort.MaxValue => PayloadType._int,
//         >= 0 => PayloadType._ushort,
//         >= short.MinValue => PayloadType._short,
//         >= int.MinValue => PayloadType._int,
//         _ => PayloadType._long
//     };

//     private static PayloadType GetPayloadType(byte value) => value switch
//     {
//         0xf8 or 0x8 => PayloadType._long, // f8 = -8 , long tem 8 bytes
//         0xfc => PayloadType._int,        // fc = -4, int tem 4 bytes
//         0xfe => PayloadType._short,     // fe = -2, short tem 2 bytes
//         0x2 => PayloadType._ushort,    // 2 byte 
//         0x4 => PayloadType._uint,     // 32bit - 4byte
//         _ => PayloadType.invalid
//     };

//     private static int PayloadSize(PayloadType payloadType) => payloadType switch
//     {
//         PayloadType._long => 8,
//         PayloadType._int or PayloadType._uint => 4,
//         PayloadType._short or PayloadType._ushort => 2
//     };

//     private static byte ByteCode(PayloadType payloadType, int payloadSize) => payloadType switch
//     {
//         PayloadType._ulong or PayloadType._uint or PayloadType._ushort => (byte)payloadSize,
//         _ => (byte)(256 - payloadSize)
//     };
//     // (long,   base-10 value: 248, hex: 0xf8)
//     // (int,    base-10 value: 252, hex: 0xfc)
//     // (short,  base-10 value: 254, hex: 0xfe)
//     // (ushort, base-10 value:   2, hex: 0x2)
//     // (uint,   base-10 value:   4, hex: 0x4)
//     // (ulong,  base-10 value:   8, hex: 0x8)

//     #endregion
// }
