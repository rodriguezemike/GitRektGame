using UnityEngine;
using System.Collections;

public class baseSkill {
	public enum SkillCategory
	{
		FLOWCONTROL,
		FUNCTION,
		DATASTRUCTURE,
		NETWORK
	}

	private string			skillName;
	private string			skillDesciption;
	private SkillCategory	skillCategory;	
	private int				skillLevel;
	private int				skillExperience;
	private int				skillCoolDown;
	private int				power;
	
	public string	SkillName { get; set; }
	public int		SkillLevel { get; set; }
	public int		SkillExperience { get; set; }
	public int		SkillCoodlDown { get; set; }
	public int		Power { get; set; }
	
	public void 	cast();
}
