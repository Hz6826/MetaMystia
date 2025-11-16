using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000302 RID: 770
	public class MoonLightSeries : CookerAssetBase
	{
		// Token: 0x06005CB4 RID: 23732 RVA: 0x001D2F00 File Offset: 0x001D1100
		// Note: this type is marked as 'beforefieldinit'.
		static MoonLightSeries()
		{
			Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "MoonLightSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr);
			MoonLightSeries.NativeFieldInfoPtr_rabbitGenerationProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "rabbitGenerationProbability");
			MoonLightSeries.NativeFieldInfoPtr_perRabbitAdditiveFeeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "perRabbitAdditiveFeeRate");
			MoonLightSeries.NativeFieldInfoPtr_rabbitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "rabbitDuration");
			MoonLightSeries.NativeFieldInfoPtr_rabbitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "rabbitOffset");
			MoonLightSeries.NativeFieldInfoPtr_rabbitParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "rabbitParent");
			MoonLightSeries.NativeFieldInfoPtr_TSUKIMI_RABBIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "TSUKIMI_RABBIT");
			MoonLightSeries.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, 100682439);
			MoonLightSeries.NativeMethodInfoPtr_OnStartCook_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, 100682440);
			MoonLightSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, 100682441);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x001D2FE4 File Offset: 0x001D11E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232470, XrefRangeEnd = 232493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoonLightSeries.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x001D3038 File Offset: 0x001D1238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232493, XrefRangeEnd = 232549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoonLightSeries.NativeMethodInfoPtr_OnStartCook_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x001D3074 File Offset: 0x001D1274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232549, XrefRangeEnd = 232550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonLightSeries() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonLightSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x000329DF File Offset: 0x00030BDF
		public MoonLightSeries(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x001D30B0 File Offset: 0x001D12B0
		// (set) Token: 0x06005CBA RID: 23738 RVA: 0x000329E8 File Offset: 0x00030BE8
		public unsafe float rabbitGenerationProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitGenerationProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitGenerationProbability)) = value;
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06005CBB RID: 23739 RVA: 0x001D30D8 File Offset: 0x001D12D8
		// (set) Token: 0x06005CBC RID: 23740 RVA: 0x00032A03 File Offset: 0x00030C03
		public unsafe float perRabbitAdditiveFeeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_perRabbitAdditiveFeeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_perRabbitAdditiveFeeRate)) = value;
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x001D3100 File Offset: 0x001D1300
		// (set) Token: 0x06005CBE RID: 23742 RVA: 0x00032A1E File Offset: 0x00030C1E
		public unsafe int rabbitDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitDuration)) = value;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06005CBF RID: 23743 RVA: 0x001D3128 File Offset: 0x001D1328
		// (set) Token: 0x06005CC0 RID: 23744 RVA: 0x00032A39 File Offset: 0x00030C39
		public unsafe Vector2 rabbitOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitOffset)) = value;
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x001D3150 File Offset: 0x001D1350
		// (set) Token: 0x06005CC2 RID: 23746 RVA: 0x00032A54 File Offset: 0x00030C54
		public unsafe GameObject rabbitParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.NativeFieldInfoPtr_rabbitParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x001D3180 File Offset: 0x001D1380
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x00032A73 File Offset: 0x00030C73
		public unsafe static string TSUKIMI_RABBIT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoonLightSeries.NativeFieldInfoPtr_TSUKIMI_RABBIT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoonLightSeries.NativeFieldInfoPtr_TSUKIMI_RABBIT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeFieldInfoPtr_rabbitGenerationProbability;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeFieldInfoPtr_perRabbitAdditiveFeeRate;

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeFieldInfoPtr_rabbitDuration;

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeFieldInfoPtr_rabbitOffset;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeFieldInfoPtr_rabbitParent;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeFieldInfoPtr_TSUKIMI_RABBIT;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D6F RID: 15727
		private static readonly IntPtr NativeMethodInfoPtr_OnStartCook_Public_Virtual_Void_0;

		// Token: 0x04003D70 RID: 15728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D29 RID: 3369
		[ObfuscatedName("GameData.Profile.MoonLightSeries+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2CB RID: 62155 RVA: 0x00398394 File Offset: 0x00396594
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoonLightSeries>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr);
				MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, "rabbit");
				MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbitSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, "rabbitSprite");
				MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, 100682443);
				MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__OnStartCook_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, 100682444);
				MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__OnStartCook_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr, 100682445);
			}

			// Token: 0x0600F2CC RID: 62156 RVA: 0x00398438 File Offset: 0x00396638
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonLightSeries.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2CD RID: 62157 RVA: 0x00398474 File Offset: 0x00396674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232441, XrefRangeEnd = 232464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnStartCook_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__OnStartCook_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2CE RID: 62158 RVA: 0x003984A8 File Offset: 0x003966A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232464, XrefRangeEnd = 232470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnStartCook_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonLightSeries.__c__DisplayClass7_0.NativeMethodInfoPtr__OnStartCook_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2CF RID: 62159 RVA: 0x000825FA File Offset: 0x000807FA
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EF7 RID: 20215
			// (get) Token: 0x0600F2D0 RID: 62160 RVA: 0x003984DC File Offset: 0x003966DC
			// (set) Token: 0x0600F2D1 RID: 62161 RVA: 0x00082603 File Offset: 0x00080803
			public unsafe GameObject rabbit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EF8 RID: 20216
			// (get) Token: 0x0600F2D2 RID: 62162 RVA: 0x0039850C File Offset: 0x0039670C
			// (set) Token: 0x0600F2D3 RID: 62163 RVA: 0x00082622 File Offset: 0x00080822
			public unsafe SpriteRenderer rabbitSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbitSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr_rabbitSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EF9 RID: 20217
			// (get) Token: 0x0600F2D4 RID: 62164 RVA: 0x0039853C File Offset: 0x0039673C
			// (set) Token: 0x0600F2D5 RID: 62165 RVA: 0x00082641 File Offset: 0x00080841
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonLightSeries.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AAF RID: 39599
			private static readonly IntPtr NativeFieldInfoPtr_rabbit;

			// Token: 0x04009AB0 RID: 39600
			private static readonly IntPtr NativeFieldInfoPtr_rabbitSprite;

			// Token: 0x04009AB1 RID: 39601
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04009AB2 RID: 39602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AB3 RID: 39603
			private static readonly IntPtr NativeMethodInfoPtr__OnStartCook_b__0_Internal_Void_0;

			// Token: 0x04009AB4 RID: 39604
			private static readonly IntPtr NativeMethodInfoPtr__OnStartCook_b__1_Internal_Void_0;
		}
	}
}
