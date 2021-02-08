using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    /// <summary>
    /// Files list with range operations.
    /// </summary>
    class MyFileList
    {
        /// <summary>
        /// List of MyFile.
        /// </summary>
        List<MyFile> list = new List<MyFile>();

        public MyFileList() { }

        public MyFileList(MyFile e)
        {
            Add(e);
        }

        /// <summary>
        /// Access to the i-th file.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public MyFile this[int i]
        {
            get
            {
                return list[i];
            }
            set
            {
                list[i] = value;
            }
        }

        public int Count => list.Count;

        /// <summary>
        /// If one of files changed.
        /// </summary>
        public bool Changed
        {
            get
            {
                foreach (MyFile e in list)
                {
                    if (e.Changed)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void Add(MyFile e)
        {
            list.Add(e);
        }

        /// <summary>
        /// Removes file at certain position.
        /// </summary>
        /// <param name="index"> File position. </param>
        /// <returns> Previous file. </returns>
        public MyFile Remove(int index)
        {
            list.RemoveAt(index);

            if (list.Count > 0) return list[Math.Max(index - 1, 0)];

            return null;
        }

        /// <summary>
        /// Save all files.
        /// </summary>
        public void SaveChanges()
        {
            foreach (MyFile e in list)
            {
                e.Save();
            }
        }
    }
}
