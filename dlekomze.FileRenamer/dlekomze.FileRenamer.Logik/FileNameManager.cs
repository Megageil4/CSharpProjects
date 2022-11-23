using dlekomze.FileRenamer.Logik.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dlekomze.FileRenamer.Logik
{
	public class FileNameManager
	{
		private List<IRenameRule> _regeln;
		public IEnumerable<IRenameRule> Rules 
		{
			get
			{
				foreach (var regel in _regeln)
				{
					yield return regel;
				}
			} 
		}
		public List<string> FilesToRename { get; set; }

		public IEnumerable<string> Preview
		{
			get 
			{
				int index = 0;
				List<string> newfiles = (List<string>)GetRenamed();
				foreach (var file in FilesToRename)
				{
					yield return $"{file} -> {newfiles[index]}";
					index++;
				}
			} 
		}

		public FileNameManager()
		{
			_regeln = new(); 
			FilesToRename = new();
		}

		public void AddRule(IRenameRule rule)
		{
			_regeln.Add(rule);
		}
		public void RemoveRule(int index)
		{
			_regeln.RemoveAt(index);
		}
		public void Rename()
		{
			int index = 0;
			foreach (var newFile in GetRenamed())
			{
				string file = FilesToRename[index];
				File.Move(file, $"{file.Remove(file.LastIndexOf('\\'))}\\{newFile}");
				index++;
			}
		}

		private IEnumerable<string> GetRenamed()
		{
			List<string> files = new();
			foreach (var file in FilesToRename)
			{
				files.Add(Path.GetFileName(file));
			}
			foreach (var rule in Rules)
			{
				List<string> newfiles = rule.Rename(files).ToList<string>();
				files.Clear();
				files.AddRange(newfiles);
			}
			return files;
		}
	}
}
