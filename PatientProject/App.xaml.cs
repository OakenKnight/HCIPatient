using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System.Windows.Media;

namespace PatientProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
    }
}
/*
 * <Style TargetType="Button" >
                <Setter Property="Foreground" Value="White"/>
                <Setter Property="Template">
                    <Setter.Value>
                        <ControlTemplate TargetType="{x:Type Button}">
                            <Grid x:Name="grid">
                                <Border x:Name="border" CornerRadius="5" BorderBrush="LightGray" BorderThickness="0"  Background="#329999">
                                    <ContentPresenter HorizontalAlignment="Center"
                                      VerticalAlignment="Center"
                                      TextElement.FontWeight="Normal">
                                    </ContentPresenter>
                                </Border>
                            </Grid>
                            <ControlTemplate.Triggers>
                                <Trigger Property="IsMouseOver" Value="True">
                                    <Setter Property="Background" TargetName="border" Value="#BEE6FD"/>
                                    <Setter Property="BorderBrush" TargetName="border" Value="#3C7FB1"/>
                                </Trigger>
                                <Trigger Property="IsPressed" Value="True">
                                    <Setter Property="BorderBrush" TargetName="border" Value="#2C628B"/>
                                </Trigger>
                                <Trigger Property="IsEnabled" Value="False">
                                    <Setter Property="Opacity" TargetName="grid" Value="0.25"/>
                                </Trigger>
                            </ControlTemplate.Triggers>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
*/