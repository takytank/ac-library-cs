﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoder
{
    /// <summary>
    /// 2-SATを解きます。 
    /// <para>
    /// 変数 x_0, x_1,…, x_{n-1} に関して (x_i=f)∨(x_j=g) というクローズを足し、これをすべて満たす変数の割当があるかを解きます。
    /// </para>
    /// </summary>
    public class TwoSat
    {
        /// <summary>
        /// <see cref="TwoSat"/> クラスの新しいインスタンスを、<paramref name="n"/> 変数の 2-SAT として初期化します。
        /// </summary>
        /// <remarks>
        /// <para>制約 : 0≤<paramref name="n"/>≤10^8</para>
        /// </remarks>
        public TwoSat(int n) { throw new NotImplementedException(); }

        /// <summary>
        /// (x_<paramref name="i"/>=<paramref name="f"/>)∨(x_<paramref name="j"/>=<paramref name="g"/>) というクローズを追加します。
        /// </summary>
        /// <remarks>
        /// <para>制約: 0≤<paramref name="i"/>&lt;n, 0≤<paramref name="j"/>&lt;n</para>
        /// <para>計算量: ならし O(1)</para>
        /// </remarks>
        public void AddClause(int i, bool f, int j, bool g) { throw new NotImplementedException(); }

        /// <summary>
        /// 条件を足す割当が存在するかどうかを判定します。
        /// </summary>
        /// <remarks>
        /// <para>制約: 複数回呼ぶことも可能。</para>
        /// <para>計算量: 足した制約の個数を m として O(n+m)</para>
        /// </remarks>
        /// <returns>割当が存在するならば <c>true</c>、そうでないなら <c>false</c>。</returns>
        public bool Satisfiable() { throw new Exception(); }

        /// <summary>
        /// 最後に実行した <see cref="Satisfiable"/> の、クローズを満たす割当を返します。実行前や、割当が存在しなかった場合は中身が未定義の長さ n の配列を返します。
        /// </summary>
        /// <remarks>
        /// <para>計算量: O(n)</para>
        /// </remarks>
        /// <returns>最後に呼んだ <see cref="Satisfiable"/> の、クローズを満たす割当の配列。</returns>
        public bool[] Answer() { throw new Exception(); }
    }
}
