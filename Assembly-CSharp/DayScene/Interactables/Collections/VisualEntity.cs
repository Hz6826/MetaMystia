using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables.Collections
{
	// Token: 0x02000163 RID: 355
	public class VisualEntity : MonoBehaviour
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x00123EC8 File Offset: 0x001220C8
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEntity()
		{
			Il2CppClassPointerStore<VisualEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections", "VisualEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr);
			VisualEntity.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "visuals");
			VisualEntity.NativeFieldInfoPtr_visualsOnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "visualsOnOff");
			VisualEntity.NativeFieldInfoPtr_collisionsOnOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "collisionsOnOn");
			VisualEntity.NativeFieldInfoPtr_collisionsOnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "collisionsOnOff");
			VisualEntity.NativeFieldInfoPtr_internalActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "internalActiveState");
			VisualEntity.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670349);
			VisualEntity.NativeMethodInfoPtr_Initialize_Public_Action_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670350);
			VisualEntity.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670351);
			VisualEntity.NativeMethodInfoPtr_UpdateAvailability_Protected_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670352);
			VisualEntity.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670353);
			VisualEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670354);
			VisualEntity.NativeMethodInfoPtr__UpdateAvailability_b__8_0_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670355);
			VisualEntity.NativeMethodInfoPtr__UpdateAvailability_b__8_1_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, 100670356);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00123FFC File Offset: 0x001221FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67544, RefRangeEnd = 67546, XrefRangeStart = 67544, XrefRangeEnd = 67546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00124030 File Offset: 0x00122230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91937, XrefRangeEnd = 91942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action<bool, bool> Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr_Initialize_Public_Action_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr3) : null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00124070 File Offset: 0x00122270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91985, RefRangeEnd = 91988, XrefRangeStart = 91942, XrefRangeEnd = 91985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float targetAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x001240B0 File Offset: 0x001222B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91988, XrefRangeEnd = 92050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateAvailability(bool shouldActive, bool shouldFadeOut = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldActive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualEntity.NativeMethodInfoPtr_UpdateAvailability_Protected_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00124108 File Offset: 0x00122308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualEntity.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00124144 File Offset: 0x00122344
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00124180 File Offset: 0x00122380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92050, XrefRangeEnd = 92055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateAvailability_b__8_0(Collider2D x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr__UpdateAvailability_b__8_0_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x001241C4 File Offset: 0x001223C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92055, XrefRangeEnd = 92060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateAvailability_b__8_1(Collider2D x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.NativeMethodInfoPtr__UpdateAvailability_b__8_1_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00017A87 File Offset: 0x00015C87
		public VisualEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x00124208 File Offset: 0x00122408
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x00017A90 File Offset: 0x00015C90
		public unsafe Il2CppReferenceArray<SpriteRenderer> visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x00124238 File Offset: 0x00122438
		// (set) Token: 0x0600282F RID: 10287 RVA: 0x00017AAF File Offset: 0x00015CAF
		public unsafe Il2CppReferenceArray<SpriteRenderer> visualsOnOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_visualsOnOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_visualsOnOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x00124268 File Offset: 0x00122468
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x00017ACE File Offset: 0x00015CCE
		public unsafe Il2CppReferenceArray<Collider2D> collisionsOnOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_collisionsOnOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_collisionsOnOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x00124298 File Offset: 0x00122498
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x00017AED File Offset: 0x00015CED
		public unsafe Il2CppReferenceArray<Collider2D> collisionsOnOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_collisionsOnOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_collisionsOnOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x001242C8 File Offset: 0x001224C8
		// (set) Token: 0x06002835 RID: 10293 RVA: 0x00017B0C File Offset: 0x00015D0C
		public Nullable<bool> internalActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_internalActiveState);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.NativeFieldInfoPtr_internalActiveState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeFieldInfoPtr_visualsOnOff;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeFieldInfoPtr_collisionsOnOn;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_collisionsOnOff;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_internalActiveState;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Action_2_Boolean_Boolean_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailability_Protected_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAvailability_b__8_0_Private_Void_Collider2D_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAvailability_b__8_1_Private_Void_Collider2D_0;

		// Token: 0x0200078E RID: 1934
		[ObfuscatedName("DayScene.Interactables.Collections.VisualEntity+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A36B RID: 41835 RVA: 0x002ADAB4 File Offset: 0x002ABCB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr);
				VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr, "alpha");
				VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_offAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr, "offAlpha");
				VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr, 100670357);
				VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__SetAlpha_b__1_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr, 100670358);
				VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__SetAlpha_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr, 100670359);
			}

			// Token: 0x0600A36C RID: 41836 RVA: 0x002ADB44 File Offset: 0x002ABD44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEntity.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A36D RID: 41837 RVA: 0x002ADB80 File Offset: 0x002ABD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91925, XrefRangeEnd = 91929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetAlpha_b__1(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__SetAlpha_b__1_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A36E RID: 41838 RVA: 0x002ADBC4 File Offset: 0x002ABDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91929, XrefRangeEnd = 91933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetAlpha_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.__c__DisplayClass7_0.NativeMethodInfoPtr__SetAlpha_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A36F RID: 41839 RVA: 0x00058416 File Offset: 0x00056616
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035E7 RID: 13799
			// (get) Token: 0x0600A370 RID: 41840 RVA: 0x002ADC08 File Offset: 0x002ABE08
			// (set) Token: 0x0600A371 RID: 41841 RVA: 0x0005841F File Offset: 0x0005661F
			public unsafe Color alpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_alpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_alpha)) = value;
				}
			}

			// Token: 0x170035E8 RID: 13800
			// (get) Token: 0x0600A372 RID: 41842 RVA: 0x002ADC30 File Offset: 0x002ABE30
			// (set) Token: 0x0600A373 RID: 41843 RVA: 0x0005843A File Offset: 0x0005663A
			public unsafe Color offAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_offAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEntity.__c__DisplayClass7_0.NativeFieldInfoPtr_offAlpha)) = value;
				}
			}

			// Token: 0x040069CD RID: 27085
			private static readonly IntPtr NativeFieldInfoPtr_alpha;

			// Token: 0x040069CE RID: 27086
			private static readonly IntPtr NativeFieldInfoPtr_offAlpha;

			// Token: 0x040069CF RID: 27087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069D0 RID: 27088
			private static readonly IntPtr NativeMethodInfoPtr__SetAlpha_b__1_Internal_Void_SpriteRenderer_0;

			// Token: 0x040069D1 RID: 27089
			private static readonly IntPtr NativeMethodInfoPtr__SetAlpha_b__2_Internal_Void_SpriteRenderer_0;
		}

		// Token: 0x0200078F RID: 1935
		[ObfuscatedName("DayScene.Interactables.Collections.VisualEntity+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A374 RID: 41844 RVA: 0x002ADC58 File Offset: 0x002ABE58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualEntity>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr);
				VisualEntity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr, "<>9");
				VisualEntity.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr, "<>9__7_0");
				VisualEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr, 100670361);
				VisualEntity.__c.NativeMethodInfoPtr__SetAlpha_b__7_0_Internal_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr, 100670362);
			}

			// Token: 0x0600A375 RID: 41845 RVA: 0x002ADCD4 File Offset: 0x002ABED4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEntity.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A376 RID: 41846 RVA: 0x002ADD10 File Offset: 0x002ABF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91933, XrefRangeEnd = 91937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetAlpha_b__7_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEntity.__c.NativeMethodInfoPtr__SetAlpha_b__7_0_Internal_Boolean_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A377 RID: 41847 RVA: 0x00058455 File Offset: 0x00056655
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035E9 RID: 13801
			// (get) Token: 0x0600A378 RID: 41848 RVA: 0x002ADD60 File Offset: 0x002ABF60
			// (set) Token: 0x0600A379 RID: 41849 RVA: 0x0005845E File Offset: 0x0005665E
			public unsafe static VisualEntity.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualEntity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualEntity.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualEntity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035EA RID: 13802
			// (get) Token: 0x0600A37A RID: 41850 RVA: 0x002ADD88 File Offset: 0x002ABF88
			// (set) Token: 0x0600A37B RID: 41851 RVA: 0x00058470 File Offset: 0x00056670
			public unsafe static Func<SpriteRenderer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualEntity.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualEntity.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069D2 RID: 27090
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069D3 RID: 27091
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040069D4 RID: 27092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069D5 RID: 27093
			private static readonly IntPtr NativeMethodInfoPtr__SetAlpha_b__7_0_Internal_Boolean_SpriteRenderer_0;
		}
	}
}
