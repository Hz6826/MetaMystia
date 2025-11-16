using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Utils
{
	// Token: 0x02000217 RID: 535
	public static class THIZKYExtendedUICluster : Il2CppSystem.Object
	{
		// Token: 0x06003DCF RID: 15823 RVA: 0x0016FF08 File Offset: 0x0016E108
		// Note: this type is marked as 'beforefieldinit'.
		static THIZKYExtendedUICluster()
		{
			Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Utils", "THIZKYExtendedUICluster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674602);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674603);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674604);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674605);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674606);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674607);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674608);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674609);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674610);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674611);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674612);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674613);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674614);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_OVERRIDE_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674615);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674616);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674617);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674618);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674619);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674620);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674621);
			THIZKYExtendedUICluster.NativeMethodInfoPtr_RECT_Public_Static_UIElementCluster_UIElementCluster_Action_1_RectTransform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, 100674622);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001700DC File Offset: 0x0016E2DC
		[CallerCount(174)]
		[CachedScanResults(RefRangeStart = 137424, RefRangeEnd = 137598, XrefRangeStart = 137420, XrefRangeEnd = 137424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster TMPUGUI(this UIElementCluster cluster, Action<TextMeshProUGUI> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00170140 File Offset: 0x0016E340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137598, XrefRangeEnd = 137602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster TMP(this UIElementCluster cluster, Action<TextMeshPro> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001701A4 File Offset: 0x0016E3A4
		[CallerCount(153)]
		[CachedScanResults(RefRangeStart = 137606, RefRangeEnd = 137759, XrefRangeStart = 137602, XrefRangeEnd = 137606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster IMAGE(this UIElementCluster cluster, Action<Image> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00170208 File Offset: 0x0016E408
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137763, RefRangeEnd = 137768, XrefRangeStart = 137759, XrefRangeEnd = 137763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster CLUSTER(this UIElementCluster cluster, Action<UIElementCluster> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x0017026C File Offset: 0x0016E46C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 137772, RefRangeEnd = 137792, XrefRangeStart = 137768, XrefRangeEnd = 137772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster SPRITERENDERER(this UIElementCluster cluster, Action<SpriteRenderer> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x001702D0 File Offset: 0x0016E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137792, XrefRangeEnd = 137796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster LINERENDERER(this UIElementCluster cluster, Action<LineRenderer> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00170334 File Offset: 0x0016E534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137796, XrefRangeEnd = 137800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster PARTICLE(this UIElementCluster cluster, Action<ParticleSystem> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00170398 File Offset: 0x0016E598
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137804, RefRangeEnd = 137810, XrefRangeStart = 137800, XrefRangeEnd = 137804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster CANVASGROUP(this UIElementCluster cluster, Action<CanvasGroup> afterAction, int skip = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x001703FC File Offset: 0x0016E5FC
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 137825, RefRangeEnd = 137977, XrefRangeStart = 137810, XrefRangeEnd = 137825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster TMPUGUI(this UIElementCluster cluster, string context, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00170464 File Offset: 0x0016E664
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 137981, RefRangeEnd = 137994, XrefRangeStart = 137977, XrefRangeEnd = 137981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster TMPUGUI(this UIElementCluster cluster, Action<TextMeshProUGUI> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001704CC File Offset: 0x0016E6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137994, XrefRangeEnd = 137998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster TMP(this UIElementCluster cluster, Action<TextMeshPro> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00170534 File Offset: 0x0016E734
		[CallerCount(134)]
		[CachedScanResults(RefRangeStart = 138002, RefRangeEnd = 138136, XrefRangeStart = 137998, XrefRangeEnd = 138002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster IMAGE(this UIElementCluster cluster, Action<Image> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x0017059C File Offset: 0x0016E79C
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 138151, RefRangeEnd = 138198, XrefRangeStart = 138136, XrefRangeEnd = 138151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster IMAGE(this UIElementCluster cluster, Sprite context, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00170604 File Offset: 0x0016E804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138213, RefRangeEnd = 138215, XrefRangeStart = 138198, XrefRangeEnd = 138213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster OVERRIDE_IMAGE(this UIElementCluster cluster, Sprite context, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_OVERRIDE_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x0017066C File Offset: 0x0016E86C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 138229, RefRangeEnd = 138237, XrefRangeStart = 138215, XrefRangeEnd = 138229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster IMAGE(this UIElementCluster cluster, Color color, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Color_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x001706D0 File Offset: 0x0016E8D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138241, RefRangeEnd = 138245, XrefRangeStart = 138237, XrefRangeEnd = 138241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster CLUSTER(this UIElementCluster cluster, Action<UIElementCluster> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00170738 File Offset: 0x0016E938
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 138249, RefRangeEnd = 138259, XrefRangeStart = 138245, XrefRangeEnd = 138249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster SPRITERENDERER(this UIElementCluster cluster, Action<SpriteRenderer> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x001707A0 File Offset: 0x0016E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138259, XrefRangeEnd = 138263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster LINERENDERER(this UIElementCluster cluster, Action<LineRenderer> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00170808 File Offset: 0x0016EA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138263, XrefRangeEnd = 138267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster PARTICLE(this UIElementCluster cluster, Action<ParticleSystem> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00170870 File Offset: 0x0016EA70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138271, RefRangeEnd = 138274, XrefRangeStart = 138267, XrefRangeEnd = 138271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster CANVASGROUP(this UIElementCluster cluster, Action<CanvasGroup> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x001708D8 File Offset: 0x0016EAD8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 138278, RefRangeEnd = 138291, XrefRangeStart = 138274, XrefRangeEnd = 138278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster RECT(this UIElementCluster cluster, Action<RectTransform> afterAction, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.NativeMethodInfoPtr_RECT_Public_Static_UIElementCluster_UIElementCluster_Action_1_RectTransform_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00022874 File Offset: 0x00020A74
		public THIZKYExtendedUICluster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_Int32_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_Int32_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_Int32_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_Int32_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_Int32_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_Int32_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_Int32_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_Int32_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_String_String_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_TMPUGUI_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshProUGUI_String_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_TMP_Public_Static_UIElementCluster_UIElementCluster_Action_1_TextMeshPro_String_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Action_1_Image_String_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_OVERRIDE_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Sprite_String_0;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeMethodInfoPtr_IMAGE_Public_Static_UIElementCluster_UIElementCluster_Color_String_0;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeMethodInfoPtr_CLUSTER_Public_Static_UIElementCluster_UIElementCluster_Action_1_UIElementCluster_String_0;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr_SPRITERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_SpriteRenderer_String_0;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeMethodInfoPtr_LINERENDERER_Public_Static_UIElementCluster_UIElementCluster_Action_1_LineRenderer_String_0;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeMethodInfoPtr_PARTICLE_Public_Static_UIElementCluster_UIElementCluster_Action_1_ParticleSystem_String_0;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeMethodInfoPtr_CANVASGROUP_Public_Static_UIElementCluster_UIElementCluster_Action_1_CanvasGroup_String_0;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_RECT_Public_Static_UIElementCluster_UIElementCluster_Action_1_RectTransform_String_0;

		// Token: 0x0200097E RID: 2430
		[ObfuscatedName("GameData.Utils.THIZKYExtendedUICluster+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC6D RID: 48237 RVA: 0x002F61F0 File Offset: 0x002F43F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr);
				THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr, "context");
				THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr, 100674623);
				THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeMethodInfoPtr__TMPUGUI_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr, 100674624);
			}

			// Token: 0x0600BC6E RID: 48238 RVA: 0x002F6258 File Offset: 0x002F4458
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC6F RID: 48239 RVA: 0x002F6294 File Offset: 0x002F4494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TMPUGUI_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeMethodInfoPtr__TMPUGUI_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC70 RID: 48240 RVA: 0x000658E2 File Offset: 0x00063AE2
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D91 RID: 15761
			// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x002F62D8 File Offset: 0x002F44D8
			// (set) Token: 0x0600BC72 RID: 48242 RVA: 0x000658EB File Offset: 0x00063AEB
			public unsafe string context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeFieldInfoPtr_context);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass8_0.NativeFieldInfoPtr_context), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040079B1 RID: 31153
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040079B2 RID: 31154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079B3 RID: 31155
			private static readonly IntPtr NativeMethodInfoPtr__TMPUGUI_b__0_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200097F RID: 2431
		[ObfuscatedName("GameData.Utils.THIZKYExtendedUICluster+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC73 RID: 48243 RVA: 0x002F6300 File Offset: 0x002F4500
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr);
				THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr, "context");
				THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr, 100674625);
				THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr, 100674626);
			}

			// Token: 0x0600BC74 RID: 48244 RVA: 0x002F6368 File Offset: 0x002F4568
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC75 RID: 48245 RVA: 0x002F63A4 File Offset: 0x002F45A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _IMAGE_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC76 RID: 48246 RVA: 0x0006590A File Offset: 0x00063B0A
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D92 RID: 15762
			// (get) Token: 0x0600BC77 RID: 48247 RVA: 0x002F63E8 File Offset: 0x002F45E8
			// (set) Token: 0x0600BC78 RID: 48248 RVA: 0x00065913 File Offset: 0x00063B13
			public unsafe Sprite context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass12_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040079B4 RID: 31156
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040079B5 RID: 31157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079B6 RID: 31158
			private static readonly IntPtr NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000980 RID: 2432
		[ObfuscatedName("GameData.Utils.THIZKYExtendedUICluster+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC79 RID: 48249 RVA: 0x002F6418 File Offset: 0x002F4618
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr);
				THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr, "context");
				THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr, 100674627);
				THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeMethodInfoPtr__OVERRIDE_IMAGE_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr, 100674628);
			}

			// Token: 0x0600BC7A RID: 48250 RVA: 0x002F6480 File Offset: 0x002F4680
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC7B RID: 48251 RVA: 0x002F64BC File Offset: 0x002F46BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137418, XrefRangeEnd = 137420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OVERRIDE_IMAGE_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeMethodInfoPtr__OVERRIDE_IMAGE_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC7C RID: 48252 RVA: 0x00065932 File Offset: 0x00063B32
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D93 RID: 15763
			// (get) Token: 0x0600BC7D RID: 48253 RVA: 0x002F6500 File Offset: 0x002F4700
			// (set) Token: 0x0600BC7E RID: 48254 RVA: 0x0006593B File Offset: 0x00063B3B
			public unsafe Sprite context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass13_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040079B7 RID: 31159
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040079B8 RID: 31160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079B9 RID: 31161
			private static readonly IntPtr NativeMethodInfoPtr__OVERRIDE_IMAGE_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000981 RID: 2433
		[ObfuscatedName("GameData.Utils.THIZKYExtendedUICluster+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC7F RID: 48255 RVA: 0x002F6530 File Offset: 0x002F4730
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<THIZKYExtendedUICluster>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr);
				THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr, "color");
				THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr, 100674629);
				THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr, 100674630);
			}

			// Token: 0x0600BC80 RID: 48256 RVA: 0x002F6598 File Offset: 0x002F4798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<THIZKYExtendedUICluster.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC81 RID: 48257 RVA: 0x002F65D4 File Offset: 0x002F47D4
			[CallerCount(0)]
			public unsafe void _IMAGE_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC82 RID: 48258 RVA: 0x0006595A File Offset: 0x00063B5A
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D94 RID: 15764
			// (get) Token: 0x0600BC83 RID: 48259 RVA: 0x002F6618 File Offset: 0x002F4818
			// (set) Token: 0x0600BC84 RID: 48260 RVA: 0x00065963 File Offset: 0x00063B63
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(THIZKYExtendedUICluster.__c__DisplayClass14_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x040079BA RID: 31162
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x040079BB RID: 31163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079BC RID: 31164
			private static readonly IntPtr NativeMethodInfoPtr__IMAGE_b__0_Internal_Void_Image_0;
		}
	}
}
