using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200009F RID: 159
	public class GuardBuff : Il2CppSystem.Object
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x000D692C File Offset: 0x000D4B2C
		// Note: this type is marked as 'beforefieldinit'.
		static GuardBuff()
		{
			Il2CppClassPointerStore<GuardBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "GuardBuff");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr);
			GuardBuff.NativeFieldInfoPtr_controlledEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, "controlledEffect");
			GuardBuff.NativeFieldInfoPtr_onBuffEffectEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, "onBuffEffectEnd");
			GuardBuff.NativeFieldInfoPtr_onBuffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, "onBuffEnd");
			GuardBuff.NativeFieldInfoPtr__Bufftype_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, "<Bufftype>k__BackingField");
			GuardBuff.NativeFieldInfoPtr__RemainingDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, "<RemainingDuration>k__BackingField");
			GuardBuff.NativeMethodInfoPtr__ctor_Public_Void_GuardBuffType_Single_Action_Action_1_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666218);
			GuardBuff.NativeMethodInfoPtr_get_Bufftype_Public_get_GuardBuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666219);
			GuardBuff.NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666220);
			GuardBuff.NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666221);
			GuardBuff.NativeMethodInfoPtr_OnBuffEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666222);
			GuardBuff.NativeMethodInfoPtr_PlayOnBuffEndEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666223);
			GuardBuff.NativeMethodInfoPtr_SetNewBuffEndAction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr, 100666224);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000D6A4C File Offset: 0x000D4C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49347, XrefRangeEnd = 49351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardBuff(GuardBuff.GuardBuffType bufftype, float duration, Action onBuffEnd, Action<GameObject> onBuffEffectEnd, GameObject controlledEffect) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardBuff>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bufftype;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEffectEnd);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlledEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr__ctor_Public_Void_GuardBuffType_Single_Action_Action_1_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000D6ADC File Offset: 0x000D4CDC
		public unsafe GuardBuff.GuardBuffType Bufftype
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_get_Bufftype_Public_get_GuardBuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000D6B18 File Offset: 0x000D4D18
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x000D6B54 File Offset: 0x000D4D54
		public unsafe float RemainingDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40374, RefRangeEnd = 40377, XrefRangeStart = 40374, XrefRangeEnd = 40377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000D6B94 File Offset: 0x000D4D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49352, XrefRangeEnd = 49353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuffEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_OnBuffEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000D6BC8 File Offset: 0x000D4DC8
		[CallerCount(0)]
		public unsafe void PlayOnBuffEndEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_PlayOnBuffEndEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000D6BFC File Offset: 0x000D4DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49353, XrefRangeEnd = 49354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewBuffEndAction(Action newOnBuffEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOnBuffEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardBuff.NativeMethodInfoPtr_SetNewBuffEndAction_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0000A834 File Offset: 0x00008A34
		public GuardBuff(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000D6C40 File Offset: 0x000D4E40
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0000A83D File Offset: 0x00008A3D
		public unsafe GameObject controlledEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_controlledEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_controlledEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x000D6C70 File Offset: 0x000D4E70
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0000A85C File Offset: 0x00008A5C
		public unsafe Action<GameObject> onBuffEffectEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_onBuffEffectEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_onBuffEffectEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x000D6CA0 File Offset: 0x000D4EA0
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000A87B File Offset: 0x00008A7B
		public unsafe Action onBuffEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_onBuffEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr_onBuffEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x000D6CD0 File Offset: 0x000D4ED0
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000A89A File Offset: 0x00008A9A
		public unsafe GuardBuff.GuardBuffType _Bufftype_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr__Bufftype_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr__Bufftype_k__BackingField)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x000D6CF8 File Offset: 0x000D4EF8
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0000A8B5 File Offset: 0x00008AB5
		public unsafe float _RemainingDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr__RemainingDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardBuff.NativeFieldInfoPtr__RemainingDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_controlledEffect;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_onBuffEffectEnd;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_onBuffEnd;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr__Bufftype_k__BackingField;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr__RemainingDuration_k__BackingField;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardBuffType_Single_Action_Action_1_GameObject_GameObject_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_Bufftype_Public_get_GuardBuffType_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingDuration_Public_get_Single_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingDuration_Public_set_Void_Single_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_OnBuffEnd_Public_Void_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_PlayOnBuffEndEffect_Public_Void_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_SetNewBuffEndAction_Public_Void_Action_0;

		// Token: 0x02000592 RID: 1426
		public enum GuardBuffType
		{
			// Token: 0x04005AE6 RID: 23270
			Shinmyoumaru_YuuSha,
			// Token: 0x04005AE7 RID: 23271
			Kagerou_PowerUp
		}
	}
}
