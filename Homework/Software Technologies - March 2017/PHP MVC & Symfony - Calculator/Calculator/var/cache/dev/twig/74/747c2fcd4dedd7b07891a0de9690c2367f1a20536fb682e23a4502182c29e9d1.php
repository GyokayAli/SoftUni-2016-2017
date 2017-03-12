<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_7fd0c94d73ddae0e2d45149e18182ac5a5186b7e3dec720661a0bee60e3846ed extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_81fe5f40beb9c12d62b1ee8b911eab065988a6a831755696d8b04a6aa627568d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_81fe5f40beb9c12d62b1ee8b911eab065988a6a831755696d8b04a6aa627568d->enter($__internal_81fe5f40beb9c12d62b1ee8b911eab065988a6a831755696d8b04a6aa627568d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_81fe5f40beb9c12d62b1ee8b911eab065988a6a831755696d8b04a6aa627568d->leave($__internal_81fe5f40beb9c12d62b1ee8b911eab065988a6a831755696d8b04a6aa627568d_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_f3a9c84e75c12e697f7ab9eadd91cadd31c9edbb87333b2ae87f97f3e724eeed = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f3a9c84e75c12e697f7ab9eadd91cadd31c9edbb87333b2ae87f97f3e724eeed->enter($__internal_f3a9c84e75c12e697f7ab9eadd91cadd31c9edbb87333b2ae87f97f3e724eeed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_f3a9c84e75c12e697f7ab9eadd91cadd31c9edbb87333b2ae87f97f3e724eeed->leave($__internal_f3a9c84e75c12e697f7ab9eadd91cadd31c9edbb87333b2ae87f97f3e724eeed_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_ef1c70f1631c4c9d6a0273b244f00bdd4320923bd32b353ff4f0060ab8d5f316 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ef1c70f1631c4c9d6a0273b244f00bdd4320923bd32b353ff4f0060ab8d5f316->enter($__internal_ef1c70f1631c4c9d6a0273b244f00bdd4320923bd32b353ff4f0060ab8d5f316_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_ef1c70f1631c4c9d6a0273b244f00bdd4320923bd32b353ff4f0060ab8d5f316->leave($__internal_ef1c70f1631c4c9d6a0273b244f00bdd4320923bd32b353ff4f0060ab8d5f316_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_183a9e43a7868a228dfbecbc081e1f8b59457a0a3a100f15169294415fc909ba = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_183a9e43a7868a228dfbecbc081e1f8b59457a0a3a100f15169294415fc909ba->enter($__internal_183a9e43a7868a228dfbecbc081e1f8b59457a0a3a100f15169294415fc909ba_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_183a9e43a7868a228dfbecbc081e1f8b59457a0a3a100f15169294415fc909ba->leave($__internal_183a9e43a7868a228dfbecbc081e1f8b59457a0a3a100f15169294415fc909ba_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
