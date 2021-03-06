using System;
using System.Collections;
using System.Collections.Generic;
using IBatisNet.DataMapper;
using LeaveWord.Dao.Interface.reply;
using LeaveWord.DataMapper;
using LeaveWord.Domain.reply;

namespace LeaveWord.Dao.IBatis.reply
{
    public class ReplyDao:IReplyDao
    {
        #region 属性

        #endregion

        #region IReplyDao 成员

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="reply">Reply实例</param>
        /// <returns>记录主键ID</returns>
        public int AddReply(Reply reply, ISqlMapper sqlMapper)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(sqlMapper.Insert("Reply.AddReply", reply));
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return id;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="reply">Reply实例</param>
        /// <returns>被修改的记录数</returns>
        public int UpdateReply(Reply reply, ISqlMapper sqlMapper)
        {
            int count = 0;

            try
            {
                //
                if (reply != null && reply.ReplyId > 0)
                {
                    count = sqlMapper.Update("Reply.UpdateReply", reply);
                }
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return count;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="reply">查询条件，Reply实例</param>
        /// <returns>满足查询条件的Reply List实例</returns>
        public IList<Reply> GetReplys(Reply reply, ISqlMapper sqlMapper)
        {
            IList<Reply> replys = new List<Reply>();

            try
            {
                replys = sqlMapper.QueryForList<Reply>("Reply.GetReplys", reply);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return replys;
        }

        /// <summary>
        /// 统计数量
        /// </summary>
        /// <param name="whereSql"></param>
        /// <param name="sqlMapper"></param>
        /// <returns></returns>
        public int GetReplyCount(string whereSql, ISqlMapper sqlMapper)
        {
            int count = 0;

            try
            {
                count = sqlMapper.QueryForObject<int>("Reply.GetReplyCount", whereSql);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return count;
        }

        /// <summary>
        /// 获取多条
        /// </summary>
        /// <param name="parameter">查询条件，Hashtable实例</param>
        /// <returns>满足查询条件的Reply List实例</returns>
        public IList<Reply> FindReplys(Hashtable parameter, ISqlMapper sqlMapper)
        {
            IList<Reply> replys = new List<Reply>();

            try
            {
                replys = sqlMapper.QueryForList<Reply>("Reply.FindReplys", parameter);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return replys;
        }

        /// <summary>
        /// 根据条件语句whereSql获取所有记录（未分页）
        /// </summary>
        /// <param name="whereSql">条件语句</param>
        /// <returns>返回列表</returns>
        public IList<Reply> GetAllReplyBySql(string whereSql, ISqlMapper sqlMapper)
        {
            IList<Reply> replys = new List<Reply>();
            try
            {
                replys = sqlMapper.QueryForList<Reply>("Reply.GetAllReplyBySql", whereSql);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return replys;

        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="reply">Reply实例</param>
        /// <returns>被删除的记录数</returns>
        public int DeleteReply(Reply reply, ISqlMapper sqlMapper)
        {
            int count = 0;

            try
            {
                // 删除
                count = sqlMapper.Delete("Reply.DeleteReply", reply);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return count;
        }

        /// <summary>
        /// 根据条件语句whereSql批量删除记录
        /// </summary>
        /// <param name="whereSql">条件语句</param>
        public int BatchDeleteReplyBySql(string whereSql, ISqlMapper sqlMapper)
        {
            int count = 0;
            try
            {
                count = sqlMapper.Delete("Reply.BatchDeleteReplyBySql", whereSql);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }
            return count;
        }


        /// <summary>
        /// 删除多条
        /// </summary>
        /// <param name="ids">欲删除的记录的ID List实例</param>
        /// <returns>被删除的记录数</returns>
        public int DeleteReplys(IList<long> ids, ISqlMapper sqlMapper)
        {
            int count = 0;
            try
            {
                // 删除部门
                count = sqlMapper.Delete("Reply.DeleteReplys", ids);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return count;
        }

        /// <summary>
        /// 分页：计数
        /// </summary>
        /// <param name="parameter">查询条件，Hashtable实例</param>
        /// <returns>满足查询条件的记录数</returns>
        public int CountReplys(Hashtable parameter, ISqlMapper sqlMapper)
        {
            int count = 0;

            try
            {
                count = sqlMapper.QueryForObject<int>("Reply.CountReplys", parameter);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return count;
        }

        /// <summary>
        /// 分页：列表
        /// </summary>
        /// <param name="sortName">排序字段名称</param>
        /// <param name="sortOrder">排序字段方式：asc/desc</param>
        /// <param name="start">当页记录开始序号</param>
        /// <param name="limit">当页记录数</param>
        /// <param name="parameter">查询条件，Hashtable实例</param>
        /// <returns>满足查询条件的Reply List实例</returns>
        public IList<Reply> PageReplys(string sortName, string sortOrder, int start, int limit, Hashtable parameter, ISqlMapper sqlMapper)
        {
            IList<Reply> replys = new List<Reply>();

            Hashtable param = parameter == null ? new Hashtable() : parameter;
            param["SortName"] = sortName;
            param["SortOrder"] = sortOrder;
            param["StartRow"] = start;
            param["EndRow"] = start + limit - 1;

            try
            {
                replys = sqlMapper.QueryForList<Reply>("Reply.PageReplys", param);
            }
            catch (Exception e)
            {
                // 抛出异常
                throw e;
            }

            return replys;
        }

        #endregion
    }
}
