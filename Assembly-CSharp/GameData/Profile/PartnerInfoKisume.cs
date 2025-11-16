using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000323 RID: 803
	public sealed class PartnerInfoKisume : PartnerInfo
	{
		// Token: 0x06005F1F RID: 24351 RVA: 0x001DB064 File Offset: 0x001D9264
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoKisume()
		{
			Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoKisume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr);
			PartnerInfoKisume.NativeFieldInfoPtr_neverWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, "neverWork");
			PartnerInfoKisume.NativeFieldInfoPtr_kisumeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, "kisumeEffect");
			PartnerInfoKisume.NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, 100682832);
			PartnerInfoKisume.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, 100682833);
			PartnerInfoKisume.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, 100682834);
			PartnerInfoKisume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, 100682835);
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x001DB10C File Offset: 0x001D930C
		public unsafe override bool IfNeverWork
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKisume.NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x001DB148 File Offset: 0x001D9348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235165, XrefRangeEnd = 235166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKisume.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x001DB1C4 File Offset: 0x001D93C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235166, XrefRangeEnd = 235169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKisume.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x001DB208 File Offset: 0x001D9408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235169, XrefRangeEnd = 235170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoKisume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKisume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x00033D12 File Offset: 0x00031F12
		public PartnerInfoKisume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x001DB244 File Offset: 0x001D9444
		// (set) Token: 0x06005F26 RID: 24358 RVA: 0x00033D1B File Offset: 0x00031F1B
		public unsafe bool neverWork
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.NativeFieldInfoPtr_neverWork);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.NativeFieldInfoPtr_neverWork)) = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x001DB26C File Offset: 0x001D946C
		// (set) Token: 0x06005F28 RID: 24360 RVA: 0x00033D36 File Offset: 0x00031F36
		public PartnerInfoKisume.KisumeEffect kisumeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.NativeFieldInfoPtr_kisumeEffect);
				return new PartnerInfoKisume.KisumeEffect(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.NativeFieldInfoPtr_kisumeEffect), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003EED RID: 16109
		private static readonly IntPtr NativeFieldInfoPtr_neverWork;

		// Token: 0x04003EEE RID: 16110
		private static readonly IntPtr NativeFieldInfoPtr_kisumeEffect;

		// Token: 0x04003EEF RID: 16111
		private static readonly IntPtr NativeMethodInfoPtr_get_IfNeverWork_Public_Virtual_get_Boolean_0;

		// Token: 0x04003EF0 RID: 16112
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D55 RID: 3413
		[Serializable]
		public sealed class KisumeEffect : ValueType
		{
			// Token: 0x0600F47D RID: 62589 RVA: 0x0039D08C File Offset: 0x0039B28C
			// Note: this type is marked as 'beforefieldinit'.
			static KisumeEffect()
			{
				Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoKisume>.NativeClassPtr, "KisumeEffect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr);
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "jumpEffectShakeAmplitude");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "jumpEffectShakeFadeDuration");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "mudamudamudaShakeAmplitude");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "mudamudamudaDuration");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "jumpEffect");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "jumpEffectDuration");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_dropEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "dropEffect");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "mudamudamudaEffect");
				PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_exclamationMarkEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr, "exclamationMarkEffect");
			}

			// Token: 0x0600F47E RID: 62590 RVA: 0x00083446 File Offset: 0x00081646
			public KisumeEffect(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F47F RID: 62591 RVA: 0x0008344F File Offset: 0x0008164F
			public KisumeEffect() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoKisume.KisumeEffect>.NativeClassPtr))
			{
			}

			// Token: 0x17004F78 RID: 20344
			// (get) Token: 0x0600F480 RID: 62592 RVA: 0x0039D16C File Offset: 0x0039B36C
			// (set) Token: 0x0600F481 RID: 62593 RVA: 0x00083461 File Offset: 0x00081661
			public unsafe float jumpEffectShakeAmplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeAmplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeAmplitude)) = value;
				}
			}

			// Token: 0x17004F79 RID: 20345
			// (get) Token: 0x0600F482 RID: 62594 RVA: 0x0039D194 File Offset: 0x0039B394
			// (set) Token: 0x0600F483 RID: 62595 RVA: 0x0008347C File Offset: 0x0008167C
			public unsafe float jumpEffectShakeFadeDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeFadeDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectShakeFadeDuration)) = value;
				}
			}

			// Token: 0x17004F7A RID: 20346
			// (get) Token: 0x0600F484 RID: 62596 RVA: 0x0039D1BC File Offset: 0x0039B3BC
			// (set) Token: 0x0600F485 RID: 62597 RVA: 0x00083497 File Offset: 0x00081697
			public unsafe float mudamudamudaShakeAmplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaShakeAmplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaShakeAmplitude)) = value;
				}
			}

			// Token: 0x17004F7B RID: 20347
			// (get) Token: 0x0600F486 RID: 62598 RVA: 0x0039D1E4 File Offset: 0x0039B3E4
			// (set) Token: 0x0600F487 RID: 62599 RVA: 0x000834B2 File Offset: 0x000816B2
			public unsafe float mudamudamudaDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaDuration)) = value;
				}
			}

			// Token: 0x17004F7C RID: 20348
			// (get) Token: 0x0600F488 RID: 62600 RVA: 0x0039D20C File Offset: 0x0039B40C
			// (set) Token: 0x0600F489 RID: 62601 RVA: 0x000834CD File Offset: 0x000816CD
			public unsafe GameObject jumpEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F7D RID: 20349
			// (get) Token: 0x0600F48A RID: 62602 RVA: 0x0039D23C File Offset: 0x0039B43C
			// (set) Token: 0x0600F48B RID: 62603 RVA: 0x000834EC File Offset: 0x000816EC
			public unsafe float jumpEffectDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_jumpEffectDuration)) = value;
				}
			}

			// Token: 0x17004F7E RID: 20350
			// (get) Token: 0x0600F48C RID: 62604 RVA: 0x0039D264 File Offset: 0x0039B464
			// (set) Token: 0x0600F48D RID: 62605 RVA: 0x00083507 File Offset: 0x00081707
			public unsafe GameObject dropEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_dropEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_dropEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F7F RID: 20351
			// (get) Token: 0x0600F48E RID: 62606 RVA: 0x0039D294 File Offset: 0x0039B494
			// (set) Token: 0x0600F48F RID: 62607 RVA: 0x00083526 File Offset: 0x00081726
			public unsafe GameObject mudamudamudaEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_mudamudamudaEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F80 RID: 20352
			// (get) Token: 0x0600F490 RID: 62608 RVA: 0x0039D2C4 File Offset: 0x0039B4C4
			// (set) Token: 0x0600F491 RID: 62609 RVA: 0x00083545 File Offset: 0x00081745
			public unsafe GameObject exclamationMarkEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_exclamationMarkEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKisume.KisumeEffect.NativeFieldInfoPtr_exclamationMarkEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BC3 RID: 39875
			private static readonly IntPtr NativeFieldInfoPtr_jumpEffectShakeAmplitude;

			// Token: 0x04009BC4 RID: 39876
			private static readonly IntPtr NativeFieldInfoPtr_jumpEffectShakeFadeDuration;

			// Token: 0x04009BC5 RID: 39877
			private static readonly IntPtr NativeFieldInfoPtr_mudamudamudaShakeAmplitude;

			// Token: 0x04009BC6 RID: 39878
			private static readonly IntPtr NativeFieldInfoPtr_mudamudamudaDuration;

			// Token: 0x04009BC7 RID: 39879
			private static readonly IntPtr NativeFieldInfoPtr_jumpEffect;

			// Token: 0x04009BC8 RID: 39880
			private static readonly IntPtr NativeFieldInfoPtr_jumpEffectDuration;

			// Token: 0x04009BC9 RID: 39881
			private static readonly IntPtr NativeFieldInfoPtr_dropEffect;

			// Token: 0x04009BCA RID: 39882
			private static readonly IntPtr NativeFieldInfoPtr_mudamudamudaEffect;

			// Token: 0x04009BCB RID: 39883
			private static readonly IntPtr NativeFieldInfoPtr_exclamationMarkEffect;
		}
	}
}
