<?php

/* base.html.twig */
class __TwigTemplate_eb8c54b0bbd751078d10368432bb8ce8105666d318d9136aaa3c8584d750acf2 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_bfb5d16036d227f39e6a65e41d8db3f91eb0e2ee9b5e629d0aa2c477d59819fc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bfb5d16036d227f39e6a65e41d8db3f91eb0e2ee9b5e629d0aa2c477d59819fc->enter($__internal_bfb5d16036d227f39e6a65e41d8db3f91eb0e2ee9b5e629d0aa2c477d59819fc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_bfb5d16036d227f39e6a65e41d8db3f91eb0e2ee9b5e629d0aa2c477d59819fc->leave($__internal_bfb5d16036d227f39e6a65e41d8db3f91eb0e2ee9b5e629d0aa2c477d59819fc_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_de724c5d6c91781dd3530e6ae51780280fe2510f4f19f75b12a5f86cb1beaec6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_de724c5d6c91781dd3530e6ae51780280fe2510f4f19f75b12a5f86cb1beaec6->enter($__internal_de724c5d6c91781dd3530e6ae51780280fe2510f4f19f75b12a5f86cb1beaec6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_de724c5d6c91781dd3530e6ae51780280fe2510f4f19f75b12a5f86cb1beaec6->leave($__internal_de724c5d6c91781dd3530e6ae51780280fe2510f4f19f75b12a5f86cb1beaec6_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_4934b337a288df0c11d77f9da25713789f55b44a72e8c11daffc46678b7a0dd0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4934b337a288df0c11d77f9da25713789f55b44a72e8c11daffc46678b7a0dd0->enter($__internal_4934b337a288df0c11d77f9da25713789f55b44a72e8c11daffc46678b7a0dd0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_4934b337a288df0c11d77f9da25713789f55b44a72e8c11daffc46678b7a0dd0->leave($__internal_4934b337a288df0c11d77f9da25713789f55b44a72e8c11daffc46678b7a0dd0_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_a321bbe7a2f528fd9b5737b51886962fb9097157a5a96e630fa138cc7c216f30 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a321bbe7a2f528fd9b5737b51886962fb9097157a5a96e630fa138cc7c216f30->enter($__internal_a321bbe7a2f528fd9b5737b51886962fb9097157a5a96e630fa138cc7c216f30_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_a321bbe7a2f528fd9b5737b51886962fb9097157a5a96e630fa138cc7c216f30->leave($__internal_a321bbe7a2f528fd9b5737b51886962fb9097157a5a96e630fa138cc7c216f30_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_f2b4189e3613a58dbcd244156e8192194afed35fa8fa9e5db8749f50a39a7fc1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f2b4189e3613a58dbcd244156e8192194afed35fa8fa9e5db8749f50a39a7fc1->enter($__internal_f2b4189e3613a58dbcd244156e8192194afed35fa8fa9e5db8749f50a39a7fc1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_f2b4189e3613a58dbcd244156e8192194afed35fa8fa9e5db8749f50a39a7fc1->leave($__internal_f2b4189e3613a58dbcd244156e8192194afed35fa8fa9e5db8749f50a39a7fc1_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_0ae791cf45603fbba413ff05e33b2c7ec9412df58b3c684794d7b09cbeb72494 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0ae791cf45603fbba413ff05e33b2c7ec9412df58b3c684794d7b09cbeb72494->enter($__internal_0ae791cf45603fbba413ff05e33b2c7ec9412df58b3c684794d7b09cbeb72494_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_0ae791cf45603fbba413ff05e33b2c7ec9412df58b3c684794d7b09cbeb72494->leave($__internal_0ae791cf45603fbba413ff05e33b2c7ec9412df58b3c684794d7b09cbeb72494_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_6de2a25893649903576a5c4ca88f78b05d7580dd0b595fb1888ae69b419af49d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6de2a25893649903576a5c4ca88f78b05d7580dd0b595fb1888ae69b419af49d->enter($__internal_6de2a25893649903576a5c4ca88f78b05d7580dd0b595fb1888ae69b419af49d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_6de2a25893649903576a5c4ca88f78b05d7580dd0b595fb1888ae69b419af49d->leave($__internal_6de2a25893649903576a5c4ca88f78b05d7580dd0b595fb1888ae69b419af49d_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_e40370bd1f43de0db235bbbff843e396efa48eecaab75ac2de3fec7ccccf70e8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e40370bd1f43de0db235bbbff843e396efa48eecaab75ac2de3fec7ccccf70e8->enter($__internal_e40370bd1f43de0db235bbbff843e396efa48eecaab75ac2de3fec7ccccf70e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_e40370bd1f43de0db235bbbff843e396efa48eecaab75ac2de3fec7ccccf70e8->leave($__internal_e40370bd1f43de0db235bbbff843e396efa48eecaab75ac2de3fec7ccccf70e8_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
