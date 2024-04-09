package pe.edu.pucp.softproductions.model;

import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.adapters.XmlAdapter;

public class TimeAdapter extends XmlAdapter<String, Time>{
    @Override
    public Time unmarshal(String v) throws Exception {
        ArrayList<SimpleDateFormat> patrones = new ArrayList<>();
        patrones.add(new SimpleDateFormat("mm:ss"));
        patrones.add(new SimpleDateFormat("m:ss"));
        patrones.add(new SimpleDateFormat("ss"));
        patrones.add(new SimpleDateFormat("s"));
        for(SimpleDateFormat sdf : patrones){
            try{
                long ms = sdf.parse(v).getTime();
                Time t = (new Time(ms));
                return t;
            }catch(Exception ex){
                System.out.println("Error haciendo la conversion...");
            }
        }
        return null;
    }

    @Override
    public String marshal(Time v) throws Exception {
        SimpleDateFormat sdf = new SimpleDateFormat("mm:ss");
        return sdf.format(v.getTime());
    }  
}