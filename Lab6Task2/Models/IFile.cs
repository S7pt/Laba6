using System.Collections.Generic;

namespace Lab5.Models
{
    public interface IFile
    {
        public void FileInformationRead(List<Lecture> lectures);
        public void FileInformationWrite(List<Lecture> lectures);
        public void FileInformationEdit(List<Lecture> lectures);
        public void RemoveExistingInformation(List<Lecture> lectures);
        public void ShowInformation(List<Lecture> lectures);
    }
}