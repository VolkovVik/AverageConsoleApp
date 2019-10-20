using System;
using System.Collections.Generic;

namespace AverageConsoleApp {

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AverageClass< T > where T : struct {

        /// <summary>
        /// Конструктор
        /// </summary>
        public AverageClass() {
            // Проверка типа данных 
            var type = typeof( T );
            if ( type == typeof( byte )   || type == typeof( sbyte ) || type == typeof( short ) ||
                 type == typeof( ushort ) || type == typeof( int )   || type == typeof( uint )  ||
                 type == typeof( long )   || type == typeof( ulong ) || type == typeof( float ) ||
                 type == typeof( double ) ) { } else {
                throw new ArgumentException( "Недопустимый тип данных" );
            }
        }

        /// <summary>
        /// Список значений
        /// </summary>
        private readonly List< T > _list = new List< T >();

        /// <summary>
        /// Добавление значения
        /// </summary>
        /// <param name="value"></param>
        public void Add( T value ) => _list.Add( value );

        /// <summary>
        /// Сброс значений
        /// </summary>
        public void Reset() => _list.Clear();

        /// <summary>
        /// Среднее значение
        /// </summary>
        /// <returns></returns>
        public T Average() {
            T result = default;
            foreach ( var item in _list ) {
                result = Add( result, item );
            }
            result = Div( result, _list.Count );
            return result;
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static T Add( T a, T b ) => ( T ) ( ( dynamic ) a + b );

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static T Div( T a, int b ) => ( T ) ( ( dynamic ) a / b );
    }
}
