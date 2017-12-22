// These are the code we added
void OnGUI(){
	if (!ShowGUI) return;

	GUI.Box(new Rect(Screen.width-207,5,207,380)," ");
	
	GUI.Label (new Rect (Screen.width-200, 5, 80, 20), "RPM");

	RPM = GUI.HorizontalSlider (new Rect (Screen.width-170, 10, 160, 20), RPM, 0, 30);
	
	if (GUI.Button (new Rect (Screen.width-200, 30, 95, 20), "Tuning 1")) SetVariation (0);
	if (GUI.Button (new Rect (Screen.width-100, 30, 95, 20), "Tuning 2")) SetVariation (1);
	if (GUI.Button (new Rect (Screen.width-200, 55, 95, 20), "Tuning 3")) SetVariation (2);
	if (GUI.Button (new Rect (Screen.width-100, 55, 95, 20), "Tuning 4")) SetVariation (3);

	if (GUI.Button (new Rect (Screen.width-200, 80, 195, 20), "Enable transparency")) EnableTransparency ();
	if (GUI.Button (new Rect (Screen.width-200, 105, 195, 20), "Disable transparency")) DisableTransparency ();
	
	elements.EngineBlock.SetActive(GUI.Toggle (new Rect (Screen.width-200, 130, 200,20), elements.EngineBlock.activeSelf, "Engine block"));
	elements.CylinderHead.SetActive(GUI.Toggle (new Rect (Screen.width-200, 150, 200, 20), elements.CylinderHead.activeSelf, "Cylinder head"));
	elements.CylinderHeadCovers.SetActive(GUI.Toggle (new Rect (Screen.width-200, 170, 200, 20), elements.CylinderHeadCovers.activeSelf, "Cylinder head covers"));
	elements.Gearbox.SetActive(GUI.Toggle (new Rect (Screen.width-200, 190, 200, 20), elements.Gearbox.activeSelf, "Gearbox"));
	elements.ExhaustManifolds.SetActive(GUI.Toggle (new Rect (Screen.width-200, 210, 200, 20), elements.ExhaustManifolds.activeSelf, "Exhaust manifold"));
	elements.FuelRail.SetActive(GUI.Toggle (new Rect (Screen.width-200, 230, 200, 20), elements.FuelRail.activeSelf, "Fuel rail"));
	elements.IntakeManifolds.SetActive(GUI.Toggle (new Rect (Screen.width-200, 250, 200, 20), elements.IntakeManifolds.activeSelf, "Intake manifold"));
	elements.Flywheel.SetActive(GUI.Toggle (new Rect (Screen.width-200, 270, 200, 20), elements.Flywheel.activeSelf, "Flywheel"));
	elements.Clutch.SetActive(GUI.Toggle (new Rect (Screen.width-200, 290, 200, 20), elements.Clutch.activeSelf, "Clutch"));
	elements.OilPan.SetActive(GUI.Toggle (new Rect (Screen.width-200, 310, 200, 20), elements.OilPan.activeSelf, "Oil pan"));
	elements.SparkPlugWires.SetActive(GUI.Toggle (new Rect (Screen.width-200, 330, 200, 20), elements.SparkPlugWires.activeSelf, "Spark plug wires"));
	elements.SparkPlugs.SetActive(GUI.Toggle (new Rect (Screen.width-200, 350, 200, 20), elements.SparkPlugs.activeSelf, "Spark plugs"));

	
}